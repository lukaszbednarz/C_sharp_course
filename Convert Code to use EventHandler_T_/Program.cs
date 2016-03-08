using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convert_Code_to_use_EventHandler_T_
{
    
    class Person
    {
        public event EventHandler<MartialStatusChangedEventArgs> MaritalStatusChanged;
        protected virtual void FireMaritalStatusChanged(bool isMarried)
        {
            if (MaritalStatusChanged != null)
            {
                MaritalStatusChanged(this, new MartialStatusChangedEventArgs(isMarried));
            }
        }

        public void GetMarried(Person newSpouse)
        {
            FireMaritalStatusChanged(true);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
