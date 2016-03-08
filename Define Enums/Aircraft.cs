using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Define_Enums
{
    enum AircraftType { FixedWing, RotaryWing, LighterThanAir}
    class Aircraft
    {
        private  AircraftType type;
        public string Name { get; set; }

        public AircraftType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
