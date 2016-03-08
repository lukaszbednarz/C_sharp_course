using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arithmetic_Delegate
{
    public class Program
    {
        delegate void ArithmeticDelegate(int num1, int num2);

        static void Add(int x, int y)
        {
            Console.WriteLine("Sum is {0}.", x + y);
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine("Difference is {0}.", x - y);
        }

        static void Main()
        {
            ArithmeticDelegate operation;

            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                operation = new ArithmeticDelegate(Add);
            }
            else
            {
                operation = new ArithmeticDelegate(Subtract);
            }

            operation(num1, num2);

            Console.ReadKey();
        }
    }

}
