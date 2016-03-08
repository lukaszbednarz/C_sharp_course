using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = numbers.Where(n => n < 5);
            
            Console.WriteLine("Numbers < 5:");

            foreach (var x in lowNums)
            {

                Console.WriteLine(x);

            }

            string[] words = { "cherry", "apple", "blueberry" };



            var sortedWords = words.OrderBy(w => w.Length);

            
            Console.WriteLine("The sorted list of words (by length):");

            foreach (var w in sortedWords)
            {

                Console.WriteLine(w);

            }




            Console.ReadLine();

        }

    }
}
