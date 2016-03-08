using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Return_Value_From_A_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;

            for (int i = 0; i < 15; i++)
            {
                date = date.AddDays(-i * i);
                string msg = String.Format("{0} was {1}.", date.ToShortDateString(), GetDaysAgo(date));
                Write(msg);
            }

            PressSomeKeyToContinue();
        }


        static string GetDaysAgo(DateTime date)
        {
            double daysAgo = DateTime.Today.Subtract(date.Date).Days;
            int weeksAgo = (int)Math.Round(daysAgo / 7.0);
            int monthsAgo = (int)Math.Round(daysAgo / 30.0);
            int yearsAgo = (int)Math.Round(daysAgo / 365.0);

            // TODO: implement this method
            if (daysAgo == 0)
            {
                return "Today";
            }
            else if (daysAgo == 1)
            {
                return "Yesterday";
            }
            else if (daysAgo < 7)
            {
                return String.Format("{0} days ago", daysAgo);
            }
            else if (daysAgo < 30)
            {
                string period = weeksAgo == 1 ? "week" : "weeks";

                return String.Format("{0} {1} ago", weeksAgo, period);
            }
            else if (daysAgo < 365)
            {
                string period = monthsAgo == 1 ? "month" : "months";
                return String.Format("{0} {1} ago", monthsAgo, period);
            }
            else
            {
                string period = yearsAgo == 1 ? "year" : "years";
                return String.Format("{0} {1} ago", yearsAgo, period);
            }
            
        }


        static string GetPluralized(string word, int count)
        {
            return count != 1 ? word + "s" : word;
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


            Console.Write((allcaps ? msg.ToUpper() : msg) + (newline ? "\n" : string.Empty));


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
