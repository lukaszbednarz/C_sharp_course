using System;
using System.Collections;
using System.Linq;
using System.Text;
using Interfaces;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IReviewable[] items = new IReviewable[]

            {

                new Movie()

                {

                    Name = "Snow White and the Huntsman", Stars = 3,

                    Review = "A visually inventive dark fairytale reheat.",

                },

 

                new Restaurant()

                {

                    Name="Chef's Table", Stars = 5,

                    Review = "Alaskan king crab was beautifully luscious.",

                },

 

                new Restaurant()

                {

                    Name = "The Cinnamon Snail", Stars = 2,

                    Review = " Their food is 'for the birds'."

                },

 

                new Movie()

                {

                    Name = "Marvel's The Avengers", Stars = 5,

                    Review = "A Marvel film that’s a bona fide marvel."
                },
            };

            ShowReviews(items);

            Console.ReadKey();
        }

        
        static void ShowReviews(IReviewable[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Review);
                Console.WriteLine("Stars: {0}", item.Stars);
                Console.WriteLine();
            }
        }
    }
}
