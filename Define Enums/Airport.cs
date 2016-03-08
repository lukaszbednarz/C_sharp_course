using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Define_Enums
{
    [Flags]
    enum AirportAmenities 
    {
        None        = 0x00,
        FastFood    = 0x01,
        FineDining  = 0x02,
        FreeWifi    = 0x04,
        Shopping    = 0x08,
    }
    class Airport
    {
        public string Name { get; set; }

        public AirportAmenities Amenities { get; set; }
    }
}
