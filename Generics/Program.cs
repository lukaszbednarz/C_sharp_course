using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new Top5<int>();
            scores.Add(20);
            scores.Add(10);
            scores.Add(40);
            scores.Add(30);
            scores.Add(60);
            scores.Add(50);
            ShowTop5(scores);

            var leaderBoard = new Top5<Player>();

            leaderBoard.Add(new Player("Wally"));
            leaderBoard.Add(new Player("Michael"));
            leaderBoard.Add(new Player("Pierre"));
            leaderBoard.Add(new Player("Mike"));
            leaderBoard.Add(new Player("Brock"));
            leaderBoard.Add(new Player("Mark"));
            
            ShowTop5(leaderBoard);

            Console.ReadKey();

        }

        static void ShowTop5<T>(Top5<T> top5) where T: IComparable<T>
        {
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Top Five Scores");
            foreach (var item in top5.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
