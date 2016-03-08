using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Person_Class;

namespace Person_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person m = new Person() 
            {
                Name = "Mickey",
                Age  = 84,
            };
                        
            Console.WriteLine(m.Description);

            PressSomeKeyToContinue();

            Person p = new Person()
            {
                Name = "Mouse",
                Age = -10,
            };
            Console.WriteLine(p.Description);

            PressSomeKeyToContinue();

        }
        static void PressSomeKeyToContinue()
        {
            ColorConsole.Write("Press any key to continue...", ConsoleColor.Green);
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}
