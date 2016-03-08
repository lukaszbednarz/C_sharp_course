using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice
{
    class MyDisposableClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Inside MyDisposableClass.Dispose()");
        }
    }
}
