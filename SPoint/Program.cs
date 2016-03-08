using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPoint
{
    class Program
    {
        struct SPoint
        {
            public int X, Y;
        }

        static void Main(string[] args)
        {
            SPoint p = new SPoint() { X = 3, Y = 4 };
            SDoublePointByRef(ref p);
            Console.WriteLine("p1 = {0},{1}", p.X, p.Y);
            Console.ReadKey();
        }

        static void SDoublePoint(SPoint p)
        {
            p.X = p.X * 2;
            p.Y = p.Y * 2;
        }

        static void SDoublePointByRef(ref SPoint p)
        {
            p.X = p.X * 2;
            p.Y = p.Y * 2;
        }



    }


}
