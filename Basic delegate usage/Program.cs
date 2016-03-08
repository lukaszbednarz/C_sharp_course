using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic_delegate_usage
{
    delegate int Transform(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Transform del1 = new Transform(Square);
            var result1 = del1.Invoke(3);
            Console.WriteLine(result1);

            Transform del2 = Cube;
            var result2 = del2(3);
            Console.WriteLine(result2);

            Console.ReadKey();
        }

        static int Square(int x)
        {
            return x * x;
        }

        static int Cube(int x)
        {
            return x * x * x;
        }
    }

}
