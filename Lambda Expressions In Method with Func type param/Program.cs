using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Expressions_In_Method_with_Func_type_param
{
    class Program
    {

        static void Main(string[] args)
        {
            // TODD: Replace each ??? with a lambda expression
            IEnumerable<double> tempsInF = new double[] { 0, 10, 32, 100, 212 };

            WriteItemsToConsole("Temperatures in Fahrenheit", tempsInF, t => String.Format("{0,6} {1}F", t, (char)176));

            IEnumerable<double> tempsInC = TransformItems(tempsInF, t =>  (t- 32)/1.8 );

            WriteItemsToConsole("Temperatures in Celsius", tempsInC, t => String.Format("{0,6:0,0} {1}C", t, (char)176));



            IEnumerable<string> names = new string[]
            {
                "Sleepy", "Grumpy", "Doc", "Happy", "Dopey", "Bashful", "Sneezy"
            };

            WriteItemsToConsole("Names", names, s => s );



            IEnumerable<Dwarf> dwarves = TransformItems(names, n => new Dwarf {Name = n});

            WriteItemsToConsole("Dwarves", dwarves, d => "Dwarf : " + d.Name );



            IEnumerable<Dwarf> sorted = dwarves.OrderBy( d => d.Name.Length ).ThenBy( d => d.Name );

            WriteItemsToConsoleWithIndex("Sorted by Name Length and Alphabetically", sorted, (i, s) => String.Format("Dwarf #{0} : {1}", i, s.Name));

            Console.ReadKey();

        }



        static IEnumerable<V> TransformItems<U, V>(IEnumerable<U> input, Func<U, V> transformItem)
        {

            var output = new List<V>();

            foreach (var item in input)
            {

                output.Add(transformItem(item));

            }

            return output;

        }



        static void WriteItemsToConsole<U>(string description, IEnumerable<U> input, Func<U, string> toString)
        {

            Console.WriteLine(description.ToUpper());

            foreach (var item in input)
            {

                Console.WriteLine("\t" + toString(item));

            }

            Console.WriteLine();

        }



        static void WriteItemsToConsoleWithIndex<U>(string description, IEnumerable<U> input, Func<int, U, string> toStringWithIndex)
        {

            Console.WriteLine(description.ToUpper());

            int count = 0;

            foreach (var item in input)
            {

                Console.WriteLine("\t" + toStringWithIndex(++count, item));

            }

            Console.WriteLine();

        }

    }



    class Dwarf
    {

        public string Name { get; set; }

    }

}
