using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implement_IEnumerable
{
    class DateRange : System.Collections.IEnumerable
    {
        private DateTime startDateTime;
        private DateTime endDateTime;

        public DateRange(DateTime startDateTime, DateTime endDateTime)
        {
            // TODO: Complete member initialization
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {

            return new DateRangeEnumerator(this);

        }


        public DateTime StartDateTime { get 
                                        {
                                         return startDateTime;
                                         }
                                       }

        public DateTime EndDateTime
        {
            get
            {
                return endDateTime;
            }
        }
    }
}
