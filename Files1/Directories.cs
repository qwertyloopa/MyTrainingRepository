using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files1
{
    internal class Directories
    {
        public string FilePath;

        public Directories(string path)
        {
            FilePath = path;
        }

        public static int GetCountOfFile(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            int count = dir.GetFiles().Length;
            return count;
        }

        public static List<FileInfo> GetFileInfo(string path)
        {
            string[] files = Directory.GetFiles(path);
            List<FileInfo> filesInfo = new List<FileInfo>();
            foreach(string f in files)
            {
                filesInfo.Add(new FileInfo(f));
            }
            return filesInfo;
        }
    }
}
