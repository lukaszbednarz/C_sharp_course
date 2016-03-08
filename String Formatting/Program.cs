using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'This Day In History' programm.");

            string date = DateTime.Today.ToShortDateString();

            Console.WriteLine("Today's date is " + date + ".\n");

            string loginMsg = "Login :";
            
            Console.Write(loginMsg);

            string            login = String.Empty;
            ConsoleKeyInfo    key;
            
            do
            {
                key = Console.ReadKey();

                // here i am trying to detect so login cannot be "Enter"
                // thus avoiding Console.ReadLine(). One can extended 
                // this behaviour to other
                // special characters or key combinations
                if (key.Key == ConsoleKey.Enter && login.Length > 0)
                    Console.WriteLine("\n");
                    // break;
                    // tried to break from the loop at this moment but
                    // when putting break;  next "else if" is not compiling
                else if (key.Key != ConsoleKey.Enter) 
                    login += key.Key;
                
                else if (key.Key == ConsoleKey.Enter)
                    Console.Write(loginMsg);
                                    
                    

            } while (key.Key != ConsoleKey.Enter || login.Length == 0);

            Console.WriteLine("Welcome " + login.ToUpper());
            
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);
        }

    }
}
