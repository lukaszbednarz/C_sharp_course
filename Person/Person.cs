using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person_Class
{
    class Person
    {
        private int m_age;

        public string Name { get; set; }

        public int Age { get
                         { 
                             return m_age;
                         } 
                         set
                         {
                             m_age = value > 0 ? value : 0; 
                         } 
                        }

        public string Description { get
                                    {
                                        return String.Format("{0}, age {1}", Name, Age);      
                                    }}
    }
}
