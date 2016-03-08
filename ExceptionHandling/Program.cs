using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageBrowser b = new ImageBrowser()
            {

                //FolderPath = @"C:\Users\Public\Pictures\Sample Pictures",
                FolderPath = @".\Images",

            };


            try
            {
                b.ListImages();
            }
            catch (Exception ex)
            {

                Console.WriteLine("An exception was thrown when trying to list images");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally { 
            }

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey(true);
        }
    }
}
