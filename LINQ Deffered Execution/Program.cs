using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Deffered_Execution
{
    class Program
    {
        static void Main(string[] args)
        {

            var residents = new List<string> { "Dopey", "Grumpy",

                       "Doc", "Happy", "Bashful", "Sneezy", "Sleepy" };



            //var query = residents.Where(n => n.Length > 5);

            var query = from r in residents
                        where r.Length > 5
                        select r.ToArray();

            residents.Add("Snow White");



            foreach (var name in query)  // put breakpoint here
            {

                // does this print "Snow White"?

                Console.WriteLine(name);

            }

            Console.ReadLine();

        }



        static bool NameIsLongerThanFiveCharacters(string n)
        {   // put breakpoint here

            return n.Length > 3;

        }

    }
}
