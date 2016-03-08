using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPoint
{
    class CPoint
    {
        public int X, Y;
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            CPoint p = new CPoint() { X = 3, Y = 4 };
            CDoublePoint(p);
            Console.WriteLine("p = {0},{1}", p.X, p.Y);

            Console.ReadKey();
        }
        
        static void CDoublePoint(CPoint p)
        {
            p.X = p.X * 2;
            p.Y = p.Y * 2;
        }

    }
}
