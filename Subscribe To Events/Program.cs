using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Subscribe_To_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var coll = new ObservableCollection<string>();

            // TODO: subscribe to an event here

            coll.CollectionChanged += onCollectionChanged;



            coll.Add("Big Mac");
            coll.Add("Filet 'O Fish");
            coll.Add("Quarter Pounder");
            coll.Add("French Fries");
            coll.Remove("Filet 'O Fish");

            Console.ReadKey();

        }

        static void onCollectionChanged(object collection, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Added following elements");
                foreach (string item in e.NewItems) 
                {
                    Console.WriteLine(item);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Removed following elements");
                foreach (string item in e.OldItems)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
