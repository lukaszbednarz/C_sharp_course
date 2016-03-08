using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Call_Dispose_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var watcher = new FileSystemWatcher(@"C:\temp") { EnableRaisingEvents = true })
            {
                watcher.Created += new System.IO.FileSystemEventHandler(watcher_Created);

                Console.WriteLine("Press a key to release the watcher reference.");
                Console.ReadKey(true);  
            }
                
                //GC.Collect(); // for experimental purposes only; not recommended in general
                //GC.WaitForPendingFinalizers(); // wait for GC and finalizer to complete

                Console.WriteLine("Press a key to exit the application.");
                Console.ReadKey(true);
            
        }

        static void watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File created");
        }

    }
}
