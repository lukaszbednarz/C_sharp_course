using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog_And_Cat
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }

        public virtual string Speak()
        {
            return String.Empty;
        }
    }
}
