using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Expressions_With_Different_Signatures
{
    delegate void MessageDelegate1();
    delegate void MessageDelegate2(string to);
    delegate void MessageDelegate3(string to, string greeting);
    delegate void MessageDelegate4(int repeat, string greeting);
    delegate int MessageDelegate5(string greeting);

    class Program
    {
        static void Main(string[] args)
        {
            MessageDelegate1 del1 = () => Console.WriteLine("Hello, world");
            del1();

            MessageDelegate2 del2 = to => Console.WriteLine("Hello, {0}", to);
            del2("Earth");

            MessageDelegate3 del3 = (greeting, to) => Console.WriteLine("{0}, {1}", greeting, to);
            del3("Moon", "Goodnight");

            MessageDelegate4 del4 = (repeat, greeting) => {
                                                            for (int i = 0; i < repeat; i++)
                                                                Console.WriteLine("{0}", greeting);
                                                            };
            del4(3, "Bueller?");

            MessageDelegate5 del5 = greeting => {
                                                    Console.WriteLine(greeting);
                                                    return greeting.Length; 
                                                  };
            int result = del5("Salutations!");

            Console.ReadKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, world");
        }

        static void Hello(string to)
        {
            Console.WriteLine("Hello, {0}", to);
        }

        static void Greeting(string to, string greeting)
        {
            Console.WriteLine("{0}, {1}", greeting, to);
        }

        static void MultiGreeting(int repeat, string greeting)
        {
            for (int i = 0; i < repeat; i++)
                Console.WriteLine("{0}", greeting);
        }

        static int GreetingCounter(string greeting)
        {
            Console.WriteLine(greeting);
            return greeting.Length;
        }
    }
}
