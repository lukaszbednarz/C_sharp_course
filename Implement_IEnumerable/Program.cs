using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implement_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {

            DateRange dateRange = new DateRange(DateTime.Today.AddDays(-6), DateTime.Today);
            foreach (DateTime date in dateRange)
            {
                Console.WriteLine(date.ToShortDateString());
            }

            Console.ReadKey();

        }
    }
}
