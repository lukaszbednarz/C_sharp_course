using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice.Gps
{
    public struct GpsPosition
    {
        double latitude;

        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (latitude > 90 || latitude < -90)
                {
                    throw new ArgumentOutOfRangeException();
                }
                latitude = value;
            }
        }

        double longitude;

        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (longitude > 180 || longitude < -180)
                {
                    throw new ArgumentOutOfRangeException();
                }
                longitude = value;
            }
        }

        public GpsPosition(double lat, double lon)
        {
            latitude = 0.0;
            longitude = 0.0;

            Latitude = lat;
            Longitude = lon;
        }
    }
}
