using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IReviewable
    {

        string Name { get; set; }

        string Review { get; set; }

        int Stars { get; set; }
    }
}
