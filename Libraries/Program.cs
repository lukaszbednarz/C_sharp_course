using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LearningLine.Lib;

namespace LearningLine.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            FolderInfo folder = new FolderInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            FolderBrowser b = new FolderBrowser(folder);

            string[] subFolders = b.GetSubFolders();
            for (int i = 0; i < subFolders.Length; i++)
            {
                folder = new FolderInfo(subFolders[i]);
                ColorConsole.Write(folder.Name, ConsoleColor.Yellow);
                ColorConsole.WriteLine("  " + folder.Description, ConsoleColor.DarkGray);
            }
        }
    }
}
