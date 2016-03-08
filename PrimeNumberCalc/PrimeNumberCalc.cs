using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice
{
    class PrimeFoundEventArgs : EventArgs
    {
        public ulong Prime;
        

        public PrimeFoundEventArgs(ulong prime)
        {
            this.Prime = prime;
        } 
    }

    class PrimeNumberCalc
    {
        public string Status { get; private set; }

        public ulong[] Run(ulong maxSearch)
        {
            var primes = new List<ulong>();
            for (ulong num = 2; num <= maxSearch; num++)
            {
                var isPrime = true;
                foreach (var prime in primes)
                {
                    isPrime = num % prime != 0;
                    if (!isPrime) break;
                }
                if (isPrime)
                {
                    primes.Add(num);
                    OnPrimeFound(new PrimeFoundEventArgs(num));
                    Status = String.Format("Number of primes: {0,10}", primes.Count);
                    OnStatusChanged();
                }
            }

            return primes.ToArray();
        }

        public event EventHandler StatusChanged;

        public event EventHandler<PrimeFoundEventArgs> PrimeFound;

        protected virtual void OnStatusChanged()
        {
            EventHandler handler = StatusChanged;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        protected virtual void OnPrimeFound(PrimeFoundEventArgs e)
        {
            EventHandler<PrimeFoundEventArgs> handler = PrimeFound;
            if (handler != null)
            {
                handler(this, e);
            }
        }


    }
}
