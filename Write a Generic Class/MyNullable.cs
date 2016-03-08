using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Write_a_Generic_Class
{
    class MyNullable<T>
    {
        private T m_value;
        public bool HasValue { get; set; }

        public T Value { get
                           { 
                                return m_value; 
                            } 
                           set
                           {
                               m_value = value;
                               if (value != null)
                               {
                                   HasValue = true;
                               }
                               else 
                               {
                                   HasValue = false;
                               }
                           }
        }

        public MyNullable()
        {
            HasValue = false;
        }
    }
}
