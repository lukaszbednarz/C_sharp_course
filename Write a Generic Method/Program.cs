using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Write_a_Generic_Method
{
    class Program
    {
        public static void Swap<T>(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }

        static void Main(string[] args)
        {
            string i = "raz", j = "dwa";
            Swap(ref i, ref j);
            Console.WriteLine("{0},{1}", i, j);
            Console.ReadKey();
        }

    }
}
