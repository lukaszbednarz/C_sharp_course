using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LearningLine.Lib
{
    public class FolderBrowser
    {
        FolderInfo currentFolder = null;

        public FolderBrowser(FolderInfo folder)
        {
            currentFolder = folder;
        }

        public FolderInfo CurrentFolder
        {
            get { return currentFolder; }
        }

        public string[] GetSubFolders()
        {
            return (from f in Directory.GetDirectories(currentFolder.Path)
                    where !(new DirectoryInfo(f).Attributes.HasFlag(FileAttributes.Hidden))
                    where !(new DirectoryInfo(f).Attributes.HasFlag(FileAttributes.System))
                    select f).ToArray();
        }

        public void MoveUpToParentFolder()
        {
            DirectoryInfo parent = Directory.GetParent(currentFolder.Path);
            if (parent != null)
            {
                currentFolder = new FolderInfo(parent.FullName);
            }
        }
    }
}
