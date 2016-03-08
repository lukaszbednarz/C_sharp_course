using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var calc = new PrimeNumberCalc();



            calc.StatusChanged += OnStatusChanged;

            calc.PrimeFound += OnPrimeFound;



            calc.Run(1000000);

            Console.ReadKey();

        }



        static void OnPrimeFound(object sender, PrimeFoundEventArgs e)
        {

            Console.SetCursorPosition(10, 3);

            Console.WriteLine("Prime number:     {0,10}", e.Prime);

            Console.SetCursorPosition(0, 10);

        }



        static void OnStatusChanged(object sender, EventArgs e)
        {

            var calc = sender as PrimeNumberCalc;

            Console.SetCursorPosition(10, 2);

            Console.WriteLine(calc.Status);

            Console.SetCursorPosition(0, 10);

        }


    }

    
}
