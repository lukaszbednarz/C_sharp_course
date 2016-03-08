using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog_And_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] pets = new Animal[2];
            pets[0] = new Dog("Samwise");
            pets[1] = new Cat("Stripes");

            foreach (var pet in pets)
            {
                Console.WriteLine(pet.Speak());
            }

            Console.ReadKey();
        }
    }

}
