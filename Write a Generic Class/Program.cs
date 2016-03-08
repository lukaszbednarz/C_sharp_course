using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Write_a_Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNullable<int> attendees = new MyNullable<int>();
            if (!attendees.HasValue)
            {
                Console.WriteLine("The attendees value has not been set.");
            }

            attendees.Value = 3;
            if (attendees.HasValue)
            {
                Console.WriteLine("The attendees value is {0}.", attendees.Value);
            }

            Console.ReadKey();
        }

    }
}
