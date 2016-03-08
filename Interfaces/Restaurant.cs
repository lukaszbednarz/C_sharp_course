using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Restaurant: IReviewable
    {
        public string Name { get; set; }

        public int Stars { get; set; }

        public string Review { get; set; }
    }
}
