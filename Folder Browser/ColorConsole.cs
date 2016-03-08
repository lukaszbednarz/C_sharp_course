using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Folder_Browser
{
    class ColorConsole
    {
        public static void Write(string msg, bool newline = true, bool allcaps = false)
        {
            Write(msg, Console.ForegroundColor, Console.BackgroundColor, newline, allcaps);

        }

        public static void Write(string msg, ConsoleColor foregroundColor, bool newline = true, bool allcaps = false)
        {
            ConsoleColor prevForegroundColor = Console.ForegroundColor;

            Write(msg, foregroundColor, Console.BackgroundColor);

            Console.ForegroundColor = prevForegroundColor;

        }


        public static void Write(string msg, ConsoleColor foregroundColor, ConsoleColor backgroundColor, bool newline = true, bool allcaps = false)
        {
            ConsoleColor prevForegroundColor = Console.ForegroundColor;
            ConsoleColor prevBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;


            Console.Write((allcaps ? msg.ToUpper() : msg) + (newline ? "\n" : string.Empty));


            Console.ForegroundColor = prevForegroundColor;
            Console.BackgroundColor = prevBackgroundColor;

        }

        public static void RainbowLine(string msg)
        {
            ConsoleColor prev = Console.ForegroundColor;
            int i = 0;
            foreach (char c in msg)
            {
                Console.ForegroundColor = (ConsoleColor.Gray + i);
                Console.Write(c);
                i = (i + 1) % 6;
            }
            Console.ForegroundColor = prev;
            Console.WriteLine();
        }


        internal static void WriteLine(string msg)
        {
            Write(msg, newline:true);
        }

        internal static void WriteLine(string msg, ConsoleColor foregroundColor)
        {
            Write(msg, foregroundColor, newline: true);
        }
    }
}
