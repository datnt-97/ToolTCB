using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private readonly List<CustomProperty> props = new List<CustomProperty>();
        [Browsable(false)]
        public List<CustomProperty> Properties { get { return props; } }

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

        public Type Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                DefaultValue = Activator.CreateInstance(value);
            }
        }

    }
}
