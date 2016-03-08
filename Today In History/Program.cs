using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using LearningLine.Practice;

namespace Numbers_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime birthDay;

            _PrintWelcomeMsg();

            _GetLoginAndGreet();

            _QuerryNumAndPrintPowers();
            
            birthDay = _QuerryBirthDayPrintDaysAndReturn();

            _PrintEventFromThisDayInHistory(birthDay);

            _AskForKeyPress();

        }

        private static void _PrintEventFromThisDayInHistory(DateTime birthDay)
        {
            string tih = TodayInHistoryDb.GetEventFromDay(birthDay.Month, birthDay.Day);
            Console.WriteLine("On {0} in history: ", birthDay.ToString("MMMM d"));
            Console.WriteLine(tih);

        }

        private static void _QuerryBirthDayAndPrintDays()
        {
            DateTime userDob;

            userDob = _QuerryBirthDayPrintDaysAndReturn();

        }

        private static DateTime _QuerryBirthDayPrintDaysAndReturn()
        {
            string userInput;
            DateTime userDob;
            TimeSpan userLifeTime;

            Console.Write("What is your birthdate? :");

            userInput = Console.ReadLine();
            userDob = DateTime.Parse(userInput);
            userLifeTime = DateTime.Now.Subtract(userDob);

            Console.WriteLine("You are {0:F2} days old.", userLifeTime.TotalDays);
            Console.WriteLine("You were born on {0}.", userDob.DayOfWeek);

            string wasOrWasNot = CultureInfo.CurrentCulture.Calendar.IsLeapYear(userDob.Year) ?
            "*was*" : "was *not*";

            Console.WriteLine("{0} {1} a lap year.\n", userDob.Year, wasOrWasNot);

            return userDob;
        }

        private static void _AskForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        private static void _QuerryNumAndPrintPowers()
        {
            Console.Write("Enter a number :");

            string userInput;
            float num;

            userInput = Console.ReadLine();
            num = float.Parse(userInput);

            string columnNames = string.Format("{0,10:G}{1,10:G}{2,10:G}", "num", "num^2", "num^3");

            string formPowers = string.Format("{0,10:F4}{1,10:F4}{2,10:F4}\n", num, Math.Pow(num, 2), Math.Pow(num, 3));

            Console.WriteLine(columnNames);

            Console.WriteLine(formPowers);



        }

        private static void _PrintWelcomeMsg()
        {
            Console.WriteLine("Welcome to 'This Day In History' programm.");

            string date = DateTime.Today.ToShortDateString();

            Console.WriteLine("Today's date is " + date + ".\n");
        }

        private static void _GetLoginAndGreet()
        {
            string loginMsg = "Login :";

            Console.Write(loginMsg);

            string login = String.Empty;
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();

                // here i am trying to detect so login cannot be "Enter"
                // thus avoiding Console.ReadLine(). One can extended 
                // this behaviour to other
                // special characters or key combinations
                if (key.Key == ConsoleKey.Enter && login.Length > 0)
                    Console.Write("\n");
                // break;
                // tried to break from the loop at this moment but
                // when putting break;  next "else if" is not compiling
                else if (key.Key != ConsoleKey.Enter)
                    login += key.Key;

                else if (key.Key == ConsoleKey.Enter)
                    Console.Write(loginMsg);



            } while (key.Key != ConsoleKey.Enter || login.Length == 0);

            Console.WriteLine("Welcome {0}.\n", login.ToUpper());



        }
    }
}
