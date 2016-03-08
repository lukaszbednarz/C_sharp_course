using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Folder_Browser
{
    class Program
    {
        static void Main(string[] args)
        {
            FolderInfo folder = new FolderInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            FolderBrowser browser = new FolderBrowser(folder);

            while (true)
            {
                Console.Clear();
                ColorConsole.WriteLine(folder.GetDescription());

                string[] subFolders = browser.GetSubFolders();
                for (int i = 0; i < subFolders.Length; i++)
                {
                    string dirName = new DirectoryInfo(subFolders[i]).Name;
                    ColorConsole.WriteLine(String.Format("{0}\t{1}", i, dirName));
                }

                ColorConsole.WriteLine("Type a subfolder number or press Enter to move to the parent folder.", ConsoleColor.DarkGray);
                ColorConsole.Write("> ");
                string input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    browser.MoveUpToParentFolder();
                    folder = browser.GetCurrentFolder();
                }
                else
                {
                    int selection = Int32.Parse(input);
                    folder = new FolderInfo(subFolders[selection]);
                    browser = new FolderBrowser(folder);
                }
            }
        }

    }
}
