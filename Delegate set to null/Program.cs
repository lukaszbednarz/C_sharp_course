using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate_set_to_null
{
    delegate int Transform(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Transform del3 = null;
            var result = del3(3);

            Console.ReadKey();
        }
    }
}
