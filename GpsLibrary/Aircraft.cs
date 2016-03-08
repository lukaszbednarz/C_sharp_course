using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice.Gps
{
    public class Aircraft
    {
        public GpsPosition Position { get; private set; }

        public Aircraft(GpsPosition initialPosition)
        {
            Position = initialPosition;
        }

        public void Fly(double dlat, double dlon)
        {
            GpsPosition before = Position;
            GpsPosition after = Position;

            after.Latitude = before.Latitude + dlat;
            after.Longitude = before.Longitude + dlon;

            Position = after;
        }
    }
}
