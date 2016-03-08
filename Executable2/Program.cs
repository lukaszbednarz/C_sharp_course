using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearningLine.Lib;

namespace Executable2
{
    class Program
    {
        static void Main(string[] args)
        {
            FolderInfo f = new FolderInfo(".");
            Console.WriteLine(f.Path);
            Console.WriteLine(f.Description);
            Console.ReadKey();
        }
    }
}
