using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Movie: IReviewable
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public string Review { get; set; }

        public DateTime[] GetShowTimes()
        {
            return new DateTime[]
            {
                DateTime.Today.AddHours(13.0),
                DateTime.Today.AddHours(15.0),
                DateTime.Today.AddHours(17.0),
                DateTime.Today.AddHours(19.0),
                DateTime.Today.AddHours(21.0),
            };
        }
    }
}
