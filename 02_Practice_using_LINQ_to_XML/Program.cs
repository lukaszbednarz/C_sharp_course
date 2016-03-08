using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _02_Practice_using_LINQ_to_XML
{
    class Program
    {
        private static string fileName = "hamlet.xml";
        private static XDocument hamlet = XDocument.Load(fileName);
        private static string fileName2 = "hamlet2.xml";
        private static XDocument hamlet2 = XDocument.Load(fileName2);
        private static XNamespace ad = "urn:learning-line:practice:play";
        
        static void Main(string[] args)
        {

            // Using LINQ to XML, load the file “hamlet.xml” and display all the “TITLE”s that are listed in the document. 
            // (The Code Snippets section below contains an extension method you may find useful.)
            //var titles = hamlet.Root.Descendants("TITLE").ToList();
            //Extensions.Display(titles, "All TITLES");

            

            // Using LINQ to XML, list all the act titles.
            //var acts = from title in hamlet.Root.Descendants("TITLE")
            //           where title.Value.StartsWith("ACT")
            //           select title;

            //Extensions.Display(acts, "Act TITLEs only");

            // Using LINQ to XML, list all the act titles.
            //var scenes = from title in hamlet.Root.Descendants("TITLE")
            //           where title.Value.StartsWith("SCENE")
            //           select title;
            
            //Extensions.Display(scenes, "Scene TITLEs only");

            // List the scenes of Act III.
            //var scenes = from title in hamlet.Root.Descendants("ACT")
            //             where title.Element("TITLE").Value.Equals("ACT III")
            //                 from scene in title.Descendants("TITLE")
            //                 where scene.Value.StartsWith("SCENE")
            //                 select scene;

            //Extensions.Display(scenes, "Act III Scene TITLEs only");

            // Use Console.ReadLine() to accept a user search string and return lines from the play 
            // that contain the user search string. Also print the speaker and the act title.

            Console.Write("Enter a search string:");
            var input = Console.ReadLine();

            var query = from act in hamlet2.Root.Descendants(ad + "ACT")
                         from sp in act.Descendants(ad + "SPEECH")
                          from line in sp.Descendants(ad + "LINE")
                            where line.Value.Contains(input)
                         
                        select new XElement("LINE", act.Element(ad + "TITLE").Value + " : " + sp.Element(ad + "SPEAKER").Value + " : " + line.Value);

            Extensions.Display(query, "Lines with querry:");

            Console.ReadLine();
        }
    }

    static class Extensions
    {
        public static void Display(this IEnumerable<XElement> elements,
            string description, int indent = 0)
        {
            Console.WriteLine("\n" + description);
            Console.WriteLine(new String('-', description.Length));
            Array.ForEach(elements.ToArray(), e => Console.WriteLine(e.Value));
        }
    }

}
