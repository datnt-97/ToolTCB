using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Transaction_Statistical_Scheduler
{
    
    public class InitParametar
    {
        public static string PathFileConfig;
        public static string PathDirectoryUtilities;
        public static string FolderSystemTrace;


        public static string SubkeyApp = @"HKEY_LOCAL_MACHINE\SOFTWARE\NPSS\TransactionStatistical";
        public static string SubkeyTask = SubkeyApp + @"\Tasks";
        public static bool RunningTask;
        public static string PathFileApp;
        public static string PathCurrentApp;
        //log application
        public static bool WriteApplication = true;
        public static bool AutoRunMode;
        public static string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        
        public static void Init()
        {
            try
            {
                //Init directory and file config
                PathFileApp = RegistryCus.GetValue(SubkeyApp, "Path");
                PathCurrentApp = Path.GetDirectoryName(PathFileApp);
                PathDirectoryUtilities = (PathCurrentApp + "\\Utilities").Replace(@"\\", @"\"); if (!Directory.Exists(PathDirectoryUtilities)) Directory.CreateDirectory(PathDirectoryUtilities);
                FolderSystemTrace = (PathCurrentApp + "\\Trace").Replace(@"\\", @"\"); if (!Directory.Exists(FolderSystemTrace)) Directory.CreateDirectory(FolderSystemTrace);
             
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
        }
    
        public static void Send_Error(string MsgError, string ClassName, string MethodName)
        {
            try
            {
                if (WriteApplication)
                {
                    WriteLogApplication(string.Format("{0:HH:mm:ss fff} Class: {1}\nMethod: {2}\n{3}", DateTime.Now, ClassName, MethodName, MsgError), true, true);
                }
                if (AutoRunMode) return;

            }
            catch
            {
            }

        }
        public static void WriteLogApplication(string msg, bool lineBegin, bool lineEnd)
        {
            try
            {
                if (!Directory.Exists(FolderSystemTrace)) Directory.CreateDirectory(FolderSystemTrace);
                string FileCcprot = string.Format("{0}\\{1:yyyyMMdd}.log", FolderSystemTrace, DateTime.Now);
                while (true)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(FileCcprot, true))
                        {
                            if (lineBegin) sw.WriteLine("----------------------------------------------");
                            sw.WriteLine(msg);
                            if (lineEnd) sw.WriteLine("----------------------------------------------\n");
                            sw.Flush();
                            sw.Close();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch
            {
                //   MessageBox.Show(ex.Message + Environment.NewLine + FolderSystemTrace, "WriteLogApplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    public static class RegistryCus
    {
        private static RegistryHive StringToRegistryHive(ref string _subKey)
        {
            if (_subKey.ToUpper().StartsWith(Registry.ClassesRoot.Name.ToUpper()))
            {
                _subKey = _subKey.ToUpper().Replace(Registry.ClassesRoot.Name.ToUpper(), string.Empty).TrimStart('\\');
                return RegistryHive.ClassesRoot;
            }
            if (_subKey.ToUpper().StartsWith(Registry.CurrentConfig.Name.ToUpper()))
            {
                _subKey = _subKey.ToUpper().Replace(Registry.CurrentConfig.Name.ToUpper(), string.Empty).TrimStart('\\');
                return RegistryHive.CurrentConfig;
            }
            if (_subKey.ToUpper().StartsWith(Registry.CurrentUser.Name.ToUpper()))
            {
                _subKey = _subKey.ToUpper().Replace(Registry.CurrentUser.Name.ToUpper(), string.Empty).TrimStart('\\');
                return RegistryHive.CurrentUser;
            }
            if (_subKey.ToUpper().StartsWith(Registry.LocalMachine.Name.ToUpper()))
            {
                _subKey = _subKey.ToUpper().Replace(Registry.LocalMachine.Name.ToUpper(), string.Empty).TrimStart('\\');
                return RegistryHive.LocalMachine;
            }
            if (_subKey.ToUpper().StartsWith(Registry.Users.Name.ToUpper()))
            {
                _subKey = _subKey.ToUpper().Replace(Registry.Users.Name.ToUpper(), string.Empty).TrimStart('\\');
                return RegistryHive.Users;
            }
            return RegistryHive.LocalMachine;
        }
        public static string GetValue(string _subKey, string _value)
        {
            try
            {
                using (RegistryKey key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref _subKey), RegistryView.Registry32).OpenSubKey(_subKey))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(_value);
                        if (o != null)
                            return o.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return string.Empty;
        }
        public static bool WriteValue(string _subKey, string _name, string _newValue)
        {
            RegistryKey key;
            try
            {
                using (key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref _subKey), RegistryView.Registry32).OpenSubKey(_subKey, true))
                {
                    if (key != null)
                    {
                        key.SetValue(_name, _newValue);
                        Object o = key.GetValue(_name);
                        if (o != null && o.ToString() == _newValue)
                        {
                            key.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        public static bool CreateSubKey(string _primaryKey, string _subkey)
        {
            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref _primaryKey), RegistryView.Registry32);
                if (RegistryKey.OpenBaseKey(StringToRegistryHive(ref _primaryKey), RegistryView.Registry32).OpenSubKey(_primaryKey + @"\" + _subkey) != null) return true;
                key.CreateSubKey(_primaryKey + @"\" + _subkey); key.Close();
                return true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        public static string[] GetValues(string _subkey)
        {
            string[] values = null;

            using (var key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref _subkey), RegistryView.Registry32).OpenSubKey(_subkey))
            {
                values = key.GetValueNames();
                key.Close();
            }
            return values;
        }
        public static bool DeleteValue(string _subKey, string _name)
        {
            try
            {
                using (var key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref _subKey), RegistryView.Registry32).OpenSubKey(_subKey))
                {
                    key.DeleteValue(_name);
                    key.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        public static bool ExistValue(string _subKey, string _name)
        {
            try
            {
                using (var key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref _subKey), RegistryView.Registry32).OpenSubKey(_subKey))
                {
                    string s = key.GetValue(_name).ToString();
                    key.Close();
                    return string.IsNullOrEmpty(s) ? false : true;
                }
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }
        public static string[] GetSubkeys(string path)
        {
            string[] values = null;
            try
            {

                using (var key = RegistryKey.OpenBaseKey(StringToRegistryHive(ref path), RegistryView.Registry32).OpenSubKey(path))
                {
                    values = key.GetSubKeyNames();
                    key.Close();
                }
            }
            catch(Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return values;
        }
    }
    public class Algorithm_TripleDES
    {
        public static string Encrypt(string toEncrypt, string KEY_Master, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(KEY_Master));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(KEY_Master);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decrypt(string cipherString, string KEY_Master, bool useHashing)
        {
            byte[] keyArray;
            //get the byte code of the string
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);
            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(KEY_Master));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(KEY_Master);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
    
}
