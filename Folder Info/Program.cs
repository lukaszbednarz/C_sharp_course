using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Folder_Info
{
    class Program
    {
        static void Main(string[] args)
        {

            //_PrintRainbowMessages();
            _PrintDirContentAndInfo("c:/windows");

            PressSomeKeyToContinue();
        }

        private static void _PrintDirContentAndInfo(string dirPath)
        {
            FolderInfo folderInfo = new FolderInfo(@"c:\windows");
            string description = folderInfo.GetDescription();
            ColorConsole.WriteLine(description);

        }

        private static void _PrintRainbowMessages()
        {
            ColorConsole.Write("Hello, ", ConsoleColor.Cyan);
            ColorConsole.WriteLine("world.");
            ColorConsole.WriteLine("Jello, whirled.", ConsoleColor.Yellow);
            ColorConsole.RainbowLine("Lots of different colors.");
        }

        static void PressSomeKeyToContinue()
        {
            ColorConsole.Write("Press any key to continue...", ConsoleColor.Green);
            Console.ReadKey(true);
            Console.WriteLine();
        }

    }
}
