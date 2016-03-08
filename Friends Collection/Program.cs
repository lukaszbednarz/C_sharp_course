using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friends
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new FriendsCollection();
            friends.Add(new Friend { Name = "Terri", Circle = "Family" },
                        new Friend { Name = "Pierre", Circle = "Friends" },
                        new Friend { Name = "ScottGu", Circle = "Following" });

            foreach (var friend in friends.GetAll())
            {
                Console.WriteLine(friend);
            }

            // test an indexer get
            var third = friends[2];
            Console.WriteLine(third);

            // test an indexer set
            friends[3] = new Friend { Name = "ScottHa", Circle = "Following" };
            Console.WriteLine(friends[3]);

            // test a string indexer
            var terri = friends["Terri"];
            Console.WriteLine(terri);

            Console.ReadKey();
        }
    }
}
