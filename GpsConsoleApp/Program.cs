using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearningLine.Practice.Gps;

namespace LearningLine.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport ord = new Airport("Chicago", new GpsPosition(42.0, -87.9));



            Console.WriteLine("\nStarting in Chicago!");

            Aircraft ac = new Aircraft(ord.Position);

            WriteAirport(ord);

            WriteAircraft(ac);



            Console.WriteLine("\nFlying to Orlando!");

            ac.Fly(-13.6, +6.6);

            WriteAirport(ord);

            WriteAircraft(ac);



            Console.WriteLine("\nFlying back to Chicago!");

            ac.Fly(+13.6, -6.6);

            WriteAirport(ord);

            WriteAircraft(ac);



            Console.ReadKey();
        }

        static void WriteAircraft(Aircraft ac)
        {
            Console.WriteLine("\tAircraft at ({0:N1}°, {1:N1}°)",
                ac.Position.Latitude,
                ac.Position.Longitude);
        }

        static void WriteAirport(Airport ap)
        {
            Console.WriteLine("\t{0} at ({1:N1}°, {2:N1}°)",
                ap.Name,
                ap.Position.Latitude,
                ap.Position.Longitude);
        }
    }
}
