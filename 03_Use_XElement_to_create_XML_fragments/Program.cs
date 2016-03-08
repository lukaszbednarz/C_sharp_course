using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _03_Use_XElement_to_create_XML_fragments
{
    class Program
    {
        static void Main(string[] args)
        {

            // A single element
            var se1 = new XElement("winner");

            Console.WriteLine(se1);


            // A single attribute
            var se2 = new XElement("winner", new XAttribute("year", 1999));
            
            Console.WriteLine(se2);
            
            //Two attributes
            var se3 = new XElement("winner", new XAttribute("year", 1999),
                                             new XAttribute("country", "England"));
            
            Console.WriteLine(se3);


            // Element text content
            var se4 = new XElement("winner", "Manchester United",
                                             new XAttribute("year", 1999),
                                             new XAttribute("country", "England"));

            Console.WriteLine(se4);

            // An XML comment
            var se5 = new XElement("winner", "Manchester United",
                                             new XAttribute("year", 1999),
                                             new XAttribute("country", "England"),
                                             new XComment("best final ever"));

            Console.WriteLine(se5);


            // A hierarchy of elements 
            var se6 = new XElement("winner", new XElement("name", "Manchester United"),
                                             new XElement("country", "England"),
                                             new XElement("year", 1999));

            var ce1 = new XElement("winners", se6);

            Console.WriteLine(ce1);

            // A larger hierarchy of elements 
            var se7 = new XElement("winner", new XElement("name", "Barcelona"),
                                             new XElement("country", "Spania"),
                                             new XElement("year", 2006));

            var se8 = new XElement("winner", new XElement("name", "Liverpool"),
                                             new XElement("country", "Anglia"),
                                             new XElement("year", 2005));

            var ce2 = new XElement("winners", se7, se8);

            Console.WriteLine(ce2);
            

            Console.ReadLine();
        }
    }
}
