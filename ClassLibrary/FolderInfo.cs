using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LearningLine.Lib
{
    public class FolderInfo
    {
        string folderPath;
        private string p;

        public FolderInfo(string path)
        {
            folderPath = path;
        }
             

        public string Name
        {
            get { return new FileInfo(folderPath).Name; }
        }

        public string Path
        {
            get { return new FileInfo(folderPath).FullName; }
        }

        private int FileCount
        {
            get { return Directory.GetFiles(folderPath).Length; }
        }

        private int SubFoldersCount
        {
            get { return Directory.GetDirectories(folderPath).Length; }
        }

        private long TotalFileSize
        {
            get
            {
                long bytes = 0;
                foreach (string file in Directory.EnumerateFiles(folderPath))
                {
                    bytes += new FileInfo(file).Length;
                }
                return bytes;
            }
        }

        public string Description
        {
            get
            {
                return String.Format("{0} files ({1:N0} bytes), {2} folders",
                    this.FileCount,
                    this.TotalFileSize,
                    this.SubFoldersCount);
            }
        }
    }
}
