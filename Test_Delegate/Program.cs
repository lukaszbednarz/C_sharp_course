using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Delegate
{
    public delegate void TestDelegate(int value);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate td = SomeMethod1;

            td += SomeMethod2;

            td += SomeClass.SomeMethod3;

            td(5);

            CallColorfully(td, 10);

            Console.ReadKey();
        }

        public static void SomeMethod1(int value)
        {
            Console.WriteLine(value);
        }
        
        public static void SomeMethod2(int value)
        {
            Console.WriteLine(value*15);
        }

        static void CallColorfully(TestDelegate d, int msg)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            d(msg);
            Console.ForegroundColor = previousColor;
        }

    }
    
    class SomeClass
    {
        public static void SomeMethod3(int value)
    {
        Console.WriteLine(value * value);
    }
    }

}
