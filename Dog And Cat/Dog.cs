using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog_And_Cat 
{
    class Dog : Animal
    {
        

        public Dog(string Name) : base(Name)
        {
        }

        public override string Speak()
        {
            return "Woof";
        }
        
    }
}
