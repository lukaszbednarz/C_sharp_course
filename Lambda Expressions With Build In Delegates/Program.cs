using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Expressions_With_Build_In_Delegates
{
    // TODO: remove these and use built-in delegates instead
    
    class Program
    {
        static void Main(string[] args)
        {
            Action del1 = () => Console.WriteLine("Hello, world");
            del1();

            Action<string> del2 = to => Console.WriteLine("Hello, {0}", to);
            del2("Dolly");

            Action<string, string> del3 = (to, greeting) => Console.WriteLine("{0}, {1}", greeting, to);
            del3("Moon", "Goodnight");

            Action<int, string> del4 = (repeat, greeting) =>
            {
                for (int i = 0; i < repeat; i++)
                    Console.WriteLine("{0}", greeting);
            };
            del4(3, "Bueller?");

            Func<string,int> del5 = greeting =>
            {
                Console.WriteLine(greeting);
                return greeting.Length;
            };
            int result = del5("Salutations!");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

}
