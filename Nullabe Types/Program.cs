using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nullabe_Types
{
    class Program
{
    public struct GpsPosition
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public GpsPosition(double lat, double lon)
            : this()
        {
            Latitude = lat;
            Longitude = lon;
        }
    }

    public class Aircraft
    {
        public string Name { get; private set; }
        public GpsPosition Position { get; private set; }
        public GpsPosition? Destination { get; set; }

        public Aircraft(string name, GpsPosition initialPosition)
        {
            Name = name;
            Position = initialPosition;
        }
    }

    static void Main(string[] args)
    {
        Aircraft ac1 = new Aircraft("B737", new GpsPosition(42, -80));
        Aircraft ac2 = new Aircraft("CRJ100", new GpsPosition(42, -80))
        {
           Destination = new GpsPosition(50,-50)
        };

        WriteAircraft(ac1);
        WriteAircraft(ac2);

        Console.ReadKey();
    }

    static void WriteAircraft(Aircraft ac)
    {
        Console.WriteLine("\nThe {0} is at ({1:N1}, {2:N1})",
            ac.Name, ac.Position.Latitude, ac.Position.Longitude);

        if (ac.Destination.HasValue)
        {
            Console.WriteLine("\nThe {0} is flying to ({1:N1}, {2:N1})",
            ac.Name, ac.Destination.Value.Latitude, ac.Destination.Value.Longitude);
        }
    }
}

}
