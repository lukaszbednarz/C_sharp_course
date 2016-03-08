using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Write_and_Call_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Starting Main()", ConsoleColor.Yellow, ConsoleColor.Green);
            PressSomeKeyToContinue();
            Write("Exiting Main()", ConsoleColor.Yellow, ConsoleColor.Green);
            PressSomeKeyToContinue();

            Write("Calling Write(msg)");
            Write("Calling Write(msg, ConsoleColor.Yellow)", ConsoleColor.Yellow);
            Write("Calling Write(msg, ConsoleColor.White, ConsoleColor.Blue)", ConsoleColor.White, ConsoleColor.Blue);
            Write("Calling Write(msg, false)", false);
            Write("Calling Write(msg, true)", true);
            Write("Calling Write(msg, allcaps: true)", allcaps: true);

            PressSomeKeyToContinue();

        }

        private static void Write(string msg, bool newline = true, bool allcaps = false)
        {
            Write(msg, Console.ForegroundColor, Console.BackgroundColor, newline, allcaps);

        }
        
        private static void Write(string msg, ConsoleColor foregroundColor, bool newline = true, bool allcaps = false)
        {
            ConsoleColor prevForegroundColor = Console.ForegroundColor;
            
            Write(msg, foregroundColor, Console.BackgroundColor);

            Console.ForegroundColor = prevForegroundColor;
            
        }


        private static void Write(string msg, ConsoleColor foregroundColor, ConsoleColor backgroundColor, bool newline = true, bool allcaps = false)
        {
            ConsoleColor prevForegroundColor = Console.ForegroundColor;
            ConsoleColor prevBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;

            
            Console.Write((allcaps? msg.ToUpper() : msg) + (newline ? "\n" : string.Empty) );


            Console.ForegroundColor = prevForegroundColor;
            Console.BackgroundColor = prevBackgroundColor;

        }

        static void PressSomeKeyToContinue()
        {
            Console.Write("Press some key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();


        }
    }
}
