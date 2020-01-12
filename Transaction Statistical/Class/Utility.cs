using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Statistical
{
    public class DirectoryFileUtilities
    {

        public FileInfo[] GetAllFilePath(string FolderPath, string[] FileFormat)
        {
            DirectoryInfo rootDirectory = new DirectoryInfo(FolderPath);
            FileInfo[] lstFileTotal = null;
            foreach (string sFormat in FileFormat)
            {
                FileInfo[] lstFileRoot = rootDirectory.GetFiles(sFormat);
                if (lstFileTotal == null) lstFileTotal = lstFileRoot; else lstFileTotal = lstFileTotal.Concat(lstFileRoot).ToArray();

            }
            DirectoryInfo[] subDirectory = rootDirectory.GetDirectories();
            foreach (DirectoryInfo sub in subDirectory)
            {
                FileInfo[] listFileSub = GetAllFilePath(sub.FullName, FileFormat);
                if (lstFileTotal != null) lstFileTotal = lstFileTotal.Concat(listFileSub).ToArray(); else lstFileTotal = listFileSub;
            }
            return lstFileTotal;
        }

    }
    public class FileComparer : IComparer<string>
    {
        public enum CompareBy
        {
            Name /* a-z */,
            LastWriteTime /* oldest to newest */,
            CreationTime  /* oldest to newest */,
            LastAccessTime /* oldest to newest */,
            FileSize /* smallest first */
        }
        // default comparison
        int _CompareBy = (int)CompareBy.Name;

        public FileComparer()
        {
        }

        public FileComparer(CompareBy compareBy)
        {
            _CompareBy = (int)compareBy;
        }

        public int Compare(string x, string y)
        {
            int output = 0;
            FileInfo file1 = new FileInfo(x);
            FileInfo file2 = new FileInfo(y);
            switch (_CompareBy)
            {
                case (int)CompareBy.LastWriteTime:
                    output = DateTime.Compare(file1.LastWriteTime, file2.LastWriteTime);
                    break;
                case (int)CompareBy.CreationTime:
                    output = DateTime.Compare(file1.CreationTime, file2.CreationTime);
                    break;
                case (int)CompareBy.LastAccessTime:
                    output = DateTime.Compare(file1.LastAccessTime, file2.LastAccessTime);
                    break;
                case (int)CompareBy.FileSize:
                    output = Convert.ToInt32(file1.Length - file2.Length);
                    break;
                case (int)CompareBy.Name:
                default:
                    output = file1.Name.CompareTo(file2.Name);
                    break;
            }
            return output;
        }
    }

    public class SortableBindingList<T> : BindingList<T> where T : class
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        public SortableBindingList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortableBindingList{T}"/> class.
        /// </summary>
        /// <param name="list">An <see cref="T:System.Collections.Generic.IList`1" /> of items to be contained in the <see cref="T:System.ComponentModel.BindingList`1" />.</param>
        public SortableBindingList(IList<T> list)
            : base(list)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the list supports sorting.
        /// </summary>
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether the list is sorted.
        /// </summary>
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }

        /// <summary>
        /// Gets the direction the list is sorted.
        /// </summary>
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        /// <summary>
        /// Gets the property descriptor that is used for sorting the list if sorting is implemented in a derived class; otherwise, returns null
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }

        /// <summary>
        /// Removes any sort applied with ApplySortCore if sorting is implemented
        /// </summary>
        protected override void RemoveSortCore()
        {
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
            _isSorted = false; //thanks Luca
        }

        /// <summary>
        /// Sorts the items if overridden in a derived class
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="direction"></param>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            List<T> list = Items as List<T>;
            if (list == null) return;

            list.Sort(Compare);

            _isSorted = true;
            //fire an event that the list has been changed.
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }


        private int Compare(T lhs, T rhs)
        {
            var result = OnComparison(lhs, rhs);
            //invert if descending
            if (_sortDirection == ListSortDirection.Descending)
                result = -result;
            return result;
        }

        private int OnComparison(T lhs, T rhs)
        {
            object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
            object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
            if (lhsValue == null)
            {
                return (rhsValue == null) ? 0 : -1; //nulls are equal
            }
            if (rhsValue == null)
            {
                return 1; //first has value, second doesn't
            }
            if (lhsValue is IComparable)
            {
                return ((IComparable)lhsValue).CompareTo(rhsValue);
            }
            if (lhsValue.Equals(rhsValue))
            {
                return 0; //both are the same
            }
            //not comparable, compare ToString
            return lhsValue.ToString().CompareTo(rhsValue.ToString());
        }
    }

    [TypeConverter(typeof(CustomObjectType.CustomObjectConverter))]
    public class CustomObjectType
    {
        //[Category("Standard")]
        //public string Name { get; set; }
        private List<CustomProperty> props = new List<CustomProperty>();
        [Browsable(false)]
        public List<CustomProperty> Properties { get { return props; } set { props = value; } }

        private Dictionary<string, object> values = new Dictionary<string, object>();

        public object this[string name]
        {
            get { object val; values.TryGetValue(name, out val); return val; }
            set { values.Remove(name); }
        }

        private class CustomObjectConverter : ExpandableObjectConverter
        {
            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
            {
                var stdProps = base.GetProperties(context, value, attributes);
                CustomObjectType obj = value as CustomObjectType;
                List<CustomProperty> customProps = obj == null ? null : obj.Properties;
                PropertyDescriptor[] props = new PropertyDescriptor[stdProps.Count + (customProps == null ? 0 : customProps.Count)];
                stdProps.CopyTo(props, 0);
                if (customProps != null)
                {
                    int index = stdProps.Count;
                    foreach (CustomProperty prop in customProps)
                    {
                        props[index++] = new CustomPropertyDescriptor(prop);
                    }
                }
                return new PropertyDescriptorCollection(props);
            }
        }
        private class CustomPropertyDescriptor : PropertyDescriptor
        {
            private readonly CustomProperty prop;
            public CustomPropertyDescriptor(CustomProperty prop) : base(prop.Name, null)
            {
                this.prop = prop;
            }
            public override string Category { get { return string.IsNullOrEmpty(prop.Cate) ? "Dynamic" : prop.Cate; } }
            public override string Description { get { return prop.Desc; } }
            public override string Name { get { return prop.Name; } }
            public override bool ShouldSerializeValue(object component) { return ((CustomObjectType)component)[prop.Name] != null; }
            public override void ResetValue(object component) { ((CustomObjectType)component)[prop.Name] = null; }
            public override bool IsReadOnly { get { return false; } }
            public override Type PropertyType { get { return prop.Type; } }
            public override bool CanResetValue(object component) { return true; }
            public override Type ComponentType { get { return typeof(CustomObjectType); } }
            public override void SetValue(object component, object value) { ((CustomObjectType)component)[prop.Name] = value; }
            public override object GetValue(object component) { return ((CustomObjectType)component)[prop.Name] ?? prop.DefaultValue; }
        }
    }

    public class CustomProperty
    {
        public string Name { get; set; }
        public string Cate { get; set; }
        public string Desc { get; set; }
        public object DefaultValue { get; set; }
        Type type;
        public string ValueDesc { get; set; }
        public string FullDesc { get; set; }
        public Type Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                //DefaultValue = Activator.CreateInstance(value);
            }
        }

    }

    public class USBDevice
    {
        public static string path = "\\Boot\\Support\\TransactionStatistical.cer";
        public static bool IsUSBKey(string usb, string serial)
        {
            if (File.Exists(usb + path))
                return ManagedAes.Decrypt(File.ReadAllText(usb + "\\Boot\\Support\\TransactionStatistical.cer"), InitParametar.prKey).Equals(serial);
            return false;
        }
        public static Dictionary<string, string> GetListUSB()
        {
            Dictionary<string, string> ls = new Dictionary<string, string>();
            try
            {
                string usb_Label = string.Empty;
                foreach (ManagementObject drive in new ManagementObjectSearcher("select * from Win32_DiskDrive where InterfaceType='USB'").Get())
                {
                    // associate physical disks with partitions

                    foreach (ManagementObject partition in new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + drive["DeviceID"] + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
                    {

                        Console.WriteLine("Partition=" + partition["Name"]);

                        // associate partitions with logical disks (drive letter volumes)

                        foreach (ManagementObject disk in new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" + partition["DeviceID"] + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
                        {
                            usb_Label = disk["Name"].ToString();
                        }
                    }
                    ls[usb_Label] = new ManagementObject("Win32_PhysicalMedia.Tag='" + drive["DeviceID"] + "'")["SerialNumber"].ToString();
                }
            }
            catch { }
            return ls;
        }
    }
    public class UtilityIniFile
    {
        //    Imports the Win32 Function "GetPrivateProfileString"
        ///   from the "Kernel32" class.
        //    I use 3 methods to gather the information. All have the same name
        //    as defind by the Win32 Function "GetPrivateProfileString"
        //
        //    First Method, Gathers the Value, as the SectionHeader and EntryKey are know.
        //
        //    Second Method, Gathers a list of EntryKey for the known SectionHeader 
        //
        //    Third Method, Gathers a list of SectionHeaders.
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);
        // First Method
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key,
               string Value, StringBuilder Result, int Size, string FileName);

        // Second Method
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, int Key,
               string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result,
               int Size, string FileName);

        // Third Method
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(int Section, string Key,
               string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result,
               int Size, string FileName);

        // Set the IniFileName passed from the Main Application.
        public string path;
        public UtilityIniFile(string INIPath)
        {
            path = INIPath;
        }
        public void Write(string Key, string Value, string Section)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, path);
        }
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return GetEntryValue(Key, Section).ToString().Length > 0;
        }
        // The Function called to obtain the SectionHeaders,
        // and returns them in an Dynamic Array.
        public string[] GetSectionNames()
        {
            //    Sets the maxsize buffer to 500, if the more
            //    is required then doubles the size each time.
            for (int maxsize = 500; true; maxsize *= 2)
            {
                //    Obtains the information in bytes and stores
                //    them in the maxsize buffer (Bytes array)
                byte[] bytes = new byte[maxsize];
                int size = GetPrivateProfileString(0, "", "", bytes, maxsize, path);

                // Check the information obtained is not bigger
                // than the allocated maxsize buffer - 2 bytes.
                // if it is, then skip over the next section
                // so that the maxsize buffer can be doubled.
                if (size < maxsize - 2)
                {
                    // Converts the bytes value into an ASCII char. This is one long string.
                    string Selected = Encoding.ASCII.GetString(bytes, 0,
                                               size - (size > 0 ? 1 : 0));
                    // Splits the Long string into an array based on the "\0"
                    // or null (Newline) value and returns the value(s) in an array
                    return Selected.Split(new char[] { '\0' });
                }
            }
        }
        // The Function called to obtain the EntryKey's from the given
        // SectionHeader string passed and returns them in an Dynamic Array
        public string[] GetEntryNames(string section)
        {
            //    Sets the maxsize buffer to 500, if the more
            //    is required then doubles the size each time. 
            for (int maxsize = 500; true; maxsize *= 2)
            {
                //    Obtains the EntryKey information in bytes
                //    and stores them in the maxsize buffer (Bytes array).
                //    Note that the SectionHeader value has been passed.
                byte[] bytes = new byte[maxsize];
                int size = GetPrivateProfileString(section, 0, "", bytes, maxsize, path);

                // Check the information obtained is not bigger
                // than the allocated maxsize buffer - 2 bytes.
                // if it is, then skip over the next section
                // so that the maxsize buffer can be doubled.
                if (size < maxsize - 2)
                {
                    // Converts the bytes value into an ASCII char.
                    // This is one long string.
                    string entries = Encoding.ASCII.GetString(bytes, 0,
                                              size - (size > 0 ? 1 : 0));
                    // Splits the Long string into an array based on the "\0"
                    // or null (Newline) value and returns the value(s) in an array
                    return entries.Split(new char[] { '\0' });
                }
            }
        }

        // The Function called to obtain the EntryKey Value from
        // the given SectionHeader and EntryKey string passed, then returned
        public string GetEntryValue(string section, string entry)
        {
            //    Sets the maxsize buffer to 250, if the more
            //    is required then doubles the size each time. 
            for (int maxsize = 250; true; maxsize *= 2)
            {
                //    Obtains the EntryValue information and uses the StringBuilder
                //    Function to and stores them in the maxsize buffers (result).
                //    Note that the SectionHeader and EntryKey values has been passed.
                StringBuilder result = new StringBuilder(maxsize);
                int size = GetPrivateProfileString(section, entry, "",
                                                   result, maxsize, path);
                if (size < maxsize - 1)
                {
                    // Returns the value gathered from the EntryKey
                    return result.ToString();
                }
            }
        }
    }
    public class HardwareInfo
    {
        public static bool IsInvalid(string info)
        {
            try
            {
                int n = 0;
                if (info.Contains(GetComputerSid())) n++; 
                else return false;              
                if (info.Contains(GetHDDSerialNo())) n++; 
                if (info.Contains(GetMACAddress())) n++;
                if (info.Contains(GetBoardProductId())) n++;          
                if (n >= 3) return true;
            }
            catch
            { }
            return false;
        }
        public static string Info()
        {
            string inf = string.Empty;
            try
            {
                inf += GetComputerSid();
                inf += GetHDDSerialNo();
                inf += GetMACAddress();              
                inf += GetBoardProductId();
            }
            catch
            { }
            return inf;
        }

        /// <summary>
        /// Gets the SID of the current PC.
        /// </summary>
        /// <returns></returns>       
        public static string GetComputerSid()
        {
            return (new SecurityIdentifier((byte[])new DirectoryEntry(string.Format("WinNT://{0},Computer", Environment.MachineName)).Children.Cast<DirectoryEntry>().First().InvokeGet("objectSID"), 0).AccountDomainSid).ToString();
        }
     
        /// <summary>
        /// Retrieving HDD Serial No.
        /// </summary>
        /// <returns></returns>
        private static String GetHDDSerialNo()
        {
            string result = "";
            try
            {
                ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
                ManagementObjectCollection mcol = mangnmt.GetInstances();

                foreach (ManagementObject strt in mcol)
                {
                    result += Convert.ToString(strt["VolumeSerialNumber"]);
                }
            }
            catch 
            {               
            }
            return result;
        }
        /// <summary>
        /// Retrieving System MAC Address.
        /// </summary>
        /// <returns></returns>
        private static string GetMACAddress()
        { 
            String sMacAddress = string.Empty;
            try     
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
          
                foreach (NetworkInterface adapter in nics)
                {
                    if (sMacAddress == String.Empty)// only return MAC Address from first card  
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        sMacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                }
            }
            catch
            { }
            return sMacAddress;
        }      
        /// <summary>
        /// Retrieving Motherboard Product Id.
        /// </summary>
        /// <returns></returns>
        private static string GetBoardProductId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject wmi in searcher.Get())
                {
                    try
                    {
                        return wmi.GetPropertyValue("Product").ToString();
                    }

                    catch { }

                }
            }
            catch (Exception ex)
            {              
            }
            return "Unknown";
        }

        /// <summary>
        /// Retrieving BIOS Maker.
        /// </summary>
        /// <returns></returns>
      
        /// <summary>
        /// Retrieving BIOS Serial No.
        /// </summary>
        /// <returns></returns>
        private static string GetBIOSserNo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

                foreach (ManagementObject wmi in searcher.Get())
                {
                    try
                    {
                        return wmi.GetPropertyValue("SerialNumber").ToString();
                    }

                    catch { }

                }
            }
            catch
            {
              
            }
            return "Unknown";
        }
        /// <summary>
        /// Retrieving BIOS Caption.
        /// </summary>
        /// <returns></returns>
        private static string GetBIOScaption()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

                foreach (ManagementObject wmi in searcher.Get())
                {
                    try
                    {
                        return wmi.GetPropertyValue("Caption").ToString();

                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
              
            }
            return "Unknown";
        }      
    }
}
