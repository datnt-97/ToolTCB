using System;
using System.Collections.Generic;
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
}
