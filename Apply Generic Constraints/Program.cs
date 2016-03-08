using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Apply_Generic_Constraints
{
    interface ITimeStamped
    {
        DateTime Created { get; }
    }

    class BigSlowClass : ITimeStamped
    {
        public DateTime Created { get; private set; }

        public BigSlowClass()
        {
            Console.WriteLine("Creating a BigSlowClass.");
            Created = DateTime.Now;
            Thread.Sleep(5000);
        }
    }

    class TimeStampedSingletonFactory<T> where T: ITimeStamped, new()
    {
        T instance;

        public T GetCurrent()
        {
            var ageOfCurrent = instance != null ?
                DateTime.Now.Subtract(instance.Created).TotalSeconds :
                new Nullable<double>();

            var shouldCreateNewInstance = ageOfCurrent == null || ageOfCurrent > 10;

            if (shouldCreateNewInstance)
            {
                instance = new T();
            }

            return instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new TimeStampedSingletonFactory<BigSlowClass>();
            while (true)
            {
                var bsc = factory.GetCurrent();
                Console.WriteLine("Instance created at {0}.", bsc.Created);
                Thread.Sleep(1000);
            }
        }

    }

}
