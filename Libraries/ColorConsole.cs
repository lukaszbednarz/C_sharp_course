using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice
{
    class ColorConsole
    {
        public static void Write(string msg, ConsoleColor foreground = ConsoleColor.Yellow)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = foreground;
            Console.Write(msg);
            Console.ForegroundColor = prev;
        }

        public static void WriteLine(string msg, ConsoleColor foreground = ConsoleColor.Yellow)
        {
            Write(msg, foreground);
            Console.WriteLine();
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
    }
}
