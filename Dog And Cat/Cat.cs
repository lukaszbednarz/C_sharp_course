using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog_And_Cat
{
    class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {
        }

        public override string Speak()
        {
            return "Miau";
        }
    }
}
