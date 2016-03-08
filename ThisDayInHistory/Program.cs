using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisDayInHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'This Day In History' programm.");

            string date = DateTime.Today.ToShortDateString();
            
            Console.WriteLine("Today's date is " + date + ".");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);
        }
    }
}
