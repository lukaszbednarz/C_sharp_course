using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Implement_IEnumerable
{
    class DateRangeEnumerator : IEnumerator
    {
        private DateRange dateRange;
        private double currentPos = -1;

        public DateRangeEnumerator(DateRange dateRange)
        {
            // TODO: Complete member initialization
            this.dateRange = dateRange;
        }

        public DateTime Current
        {
            get { return dateRange.StartDateTime.AddDays(currentPos); }
        }

        public void Dispose()
        {
            
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            currentPos++;
            return currentPos < dateRange.EndDateTime.Day - dateRange.StartDateTime.Day;
        }

        public void Reset()
        {
            currentPos = -1;
        }

        
    }
}
