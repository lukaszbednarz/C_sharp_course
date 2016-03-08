using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int>()
            {
            0, 1, 1, 2, 3, 5, 8, 13, 21,
            };
            Console.WriteLine("Fibonacci sequence:");
            ints.ForEach(i => Console.WriteLine("\t" + i)); // use lambda here

            var answer = ints.Find(i => i >= 10 && i <= 99); // use lambda here
            Console.WriteLine("\n2-digit Fibonacci number: " + answer);

            var names = new List<string>()
            {
            "Micky", "Davy", "Peter", "Michael",
            };
            Console.WriteLine("\nMonkees sorted by name length:");
            names.Sort((s1,s2) => s1.Length.CompareTo(s2.Length)); // use lambda here
            names.ForEach( item => Console.WriteLine("\t" + item));  // use lambda here

            Console.ReadKey();
        }
       
               
    }

}
