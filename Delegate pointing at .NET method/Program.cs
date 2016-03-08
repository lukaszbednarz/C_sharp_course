using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_pointing_at.NET_method
{
    delegate void PrintDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            PrintDelegate del4 = Console.WriteLine;
            del4("Hello, world!");

            Console.ReadKey();
        }
    }

}
