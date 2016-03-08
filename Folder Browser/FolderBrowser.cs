using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Folder_Browser
{
    class FolderBrowser
    {
        private FolderInfo folder;
        private IEnumerable<string> dirs;

        public FolderBrowser(FolderInfo folder)
        {
            // TODO: Complete member initialization
            this.folder = folder;
            changeFolder(folder.GetFolderPath());
            
        }

        private void changeFolder(string folderPath)
        {
           folder = new FolderInfo(folderPath);
        }

        internal string[] GetSubFolders()
        {
            dirs = Directory.EnumerateDirectories(folder.GetFolderPath());

            return dirs.ToArray();
        }

        internal void MoveUpToParentFolder()
        {

            string parentFolder = folder.GetFolderPath();
                        
            try
            {
                // Obtain the file system entries in the directory path.
                if (Directory.GetParent(parentFolder) != null)
                {
                    parentFolder = Directory.GetParent(parentFolder).FullName;
                }
            }
            catch (ArgumentNullException)
            {
                System.Console.WriteLine("Path is a null reference.");
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("Path is a null reference.");
            }
            
            changeFolder(parentFolder);
        }

        internal FolderInfo GetCurrentFolder()
        {
            return folder;
        }
    }
}
