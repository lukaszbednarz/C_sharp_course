using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friends
{
    class Friend
    {
        public string Name { get; set; }
        public string Circle { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Name, Circle);
        }
    }
}
