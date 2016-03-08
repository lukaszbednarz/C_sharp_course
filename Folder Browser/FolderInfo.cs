using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Folder_Browser
{
    class FolderInfo
    {
        private
            string m_FolderPath;

        public
            FolderInfo(string directory)
        {
            m_FolderPath = directory;

        }

        public string GetDescription()
        {



            IEnumerable<string> files;
            IEnumerable<string> dirs;
            
            files = Directory.EnumerateFiles(m_FolderPath);
            dirs  = Directory.EnumerateDirectories(m_FolderPath);
            
            return String.Format("{0} \n{1} files ({2:N0} bytes), {3} folders", 
                                 m_FolderPath,  
                                 files.Count().ToString(),  
                                 GetSizeOfFiles(),
                                 dirs.Count().ToString()
                                 );

        }

        public long GetSizeOfFiles()
        {
            long bytes = 0;
            // assumes an instance field called m_FolderPath
            foreach (string file in Directory.EnumerateFiles(m_FolderPath))
            {
                bytes += new FileInfo(file).Length;
            }
            return bytes;
        }


        internal string GetFolderPath()
        {
            return m_FolderPath;
        }
    }
}
