using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Top5<T>  where T: IComparable<T>
    {
        // stores the five highest items
        T[] top5 = new T[5];

        // (potentially) add an item to the list
        public void Add(T item)
        {
            for (int i = 0; i < 5; i++)
            {
                if (item != null && item.CompareTo(top5[i]) > 0)
                {
                    T temp = top5[i];
                    top5[i] = item;
                    item = temp;
                }
            }
        }

        // return the items for a foreach loop
        public IEnumerable<T> Items
        {
            get { return top5; }
        }
    }
}
