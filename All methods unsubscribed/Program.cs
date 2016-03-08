using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace All_methods_unsubscribed
{
    delegate void PrintDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            PrintDelegate del4 = Console.WriteLine;
            del4 += WriteLineAllCaps;
            del4 -= Console.WriteLine;
            del4 -= WriteLineAllCaps;
            if (del4 != null)
                del4("Yellow furled!");

            Console.ReadKey();
        }
        static void WriteLineAllCaps(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }
    }

}
