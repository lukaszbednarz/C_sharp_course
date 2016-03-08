using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice.Gps
{
    public class Airport
    {
        public string Name { get; private set; }
        public GpsPosition Position { get; private set; }

        public Airport(string name, GpsPosition position)
        {
            Name = name;
            Position = position;
        }
    }
}
