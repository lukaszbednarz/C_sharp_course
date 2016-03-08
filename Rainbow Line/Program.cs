using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Rainbow_Line
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
            string[]    dirContents;
            List<int>   fileLengths = new List<int> {};
            int maxLength;
            string format;
            
            dirContents = Directory.GetFiles(dirPath);
                        
            foreach (string file in dirContents)
            {
                fileLengths.Add(file.Length);
            }

            maxLength = fileLengths.Max() + 3;
            
            format = string.Format("{{0,-{0}}}", maxLength);

            ColorConsole.Write(string.Format(format, "FileName"));
            
            foreach (string file in dirContents)
            {
                FileInfo fileInfo = new FileInfo(file);
                string outLine = string.Format(format, fileInfo.Name) + fileInfo.Length.ToString();
                
                ColorConsole.Write(outLine);
                File.AppendAllText("dir.txt", outLine +Environment.NewLine);
            };
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
