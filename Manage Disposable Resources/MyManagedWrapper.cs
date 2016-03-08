using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice
{
    class MyManagedWrapper : IDisposable
    {
        IntPtr ptr; // pointer to some unmanaged resource
        MyDisposableClass other; 

        public MyManagedWrapper()
        {
            Console.WriteLine("Inside ManagedWrapper ctor.");

            ptr = new IntPtr(0x42); // fake address just for testing
            other = new MyDisposableClass();
        }

        ~MyManagedWrapper()
        {
            Console.WriteLine("In MyManagedWrapper.Finalizer.");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        bool isDisposed = false;
        protected virtual void Dispose(bool isDisposing)
        {
            if (!isDisposed)
            {
                Console.WriteLine("Inside MyManagedWrapper.Dispose({0})", isDisposing);

                if (isDisposing)
                {
                    other.Dispose();
                    GC.SuppressFinalize(this);
                }

                ptr = IntPtr.Zero;
                isDisposed = true;
            }
        }
    }
}
