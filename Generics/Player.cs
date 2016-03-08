using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Points { get; set; }

        static Random rng = new Random();

        public Player(string name)
        {
            Name = name;
            Points = rng.Next(100);
        }

        public override string ToString()
        {
            return String.Format("{0,-12}{1} points", Name, Points);
        }

        public int CompareTo(Player other)
        {
            if (other == null)
            {
                return 1;
             }

            return this.Points.CompareTo(other.Points);
            }
        }


}
