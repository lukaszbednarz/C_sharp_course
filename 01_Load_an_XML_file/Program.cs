using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _01_Load_an_XML_file
{
    
    class Book {
        public string author { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public double price { get; set; }
        public DateTime publish_date { get; set; }
        public string description { get; set; }
    }
    
    class Program
    {
        private static string fileName = "..\\..\\21.xml";
        private static XDocument doc = XDocument.Load(fileName);
        
        static void Main(string[] args)
        {
            // Print all the <book> elements to the console window.

            //foreach (XElement book in doc.Elements("catalog").Elements("book"))
            //    Console.WriteLine(book);

            
            //// Print the child elements of the first book element to the console window.
            //var querry = doc.Element("catalog")
            //                .Element("book")
            //                .Elements();

            //foreach (XElement result in querry)
            //    Console.WriteLine(result);

            // The content of the title of the first book
            //var result = doc.Elements()
            //                .Elements("book")
            //                .First()
            //                .Element("title")
            //                .Value;

            //Console.WriteLine(result);
            
            // get the book's attribute
            //var query = doc.Elements()
            //               .Elements("book")
            //               .Attributes();

            //Array.ForEach(query.ToArray(), a => Console.WriteLine(a));

            // add the attribute
            //var allBooks = from book in doc.Elements("catalog").Elements("book") select book;

            //foreach (var b in allBooks)
            //{
            //    b.Element("price").Add(new XAttribute("currency", "$"));
            //}

            //doc.Save(fileName);
            //Console.WriteLine("Attribute currency has been added");

            // remove an attribute

            //var allBooks = from book in doc.Elements("catalog").Elements("book") select book;

            //foreach (var b in allBooks)
            //{
            //    b.Element("price").Attribute("currency").Remove();
            //}

            //doc.Save(fileName);
            //Console.WriteLine("Attribute currency has been removed");

            //Continue reading and parsing the books.xml file in a console application. 
            // Use what you just learned about casting an XElement to the desired data type.

            //var allPrices = from book in doc.Elements("catalog").Elements("book") select book.Element("price");

            //foreach (var p in allPrices)
            //{
            //    var price = (double)p;

            //    Console.WriteLine("$",  price);
            //}

            //Console.WriteLine("Attribute currency has been removed");

            //
                     

            // •Query the XML for both the title and price.
            //var allBooks = from book in doc.Elements("catalog").Elements("book") select new {price =  book.Element("price"),
            //                                                                                 title = book.Element("title")
            //};

            //foreach (var p in allBooks)
            //{
            //    var price = (double)p.price;
            //    var title = p.title.Value;

            //    Console.WriteLine("Title: \"{0}\", Price: ${1}", title, price);
            //}
            
            // •Project the results (using a LINQ select statement) onto an anonymous type or your own Book class.

            var allBooks = from book in doc.Elements("catalog").Elements("book")
                           select new Book()
                           {
                               price        = (double)book.Element("price"),
                               title        = book.Element("title").Value,
                               author       = book.Element("author").Value,
                               genre        = book.Element("genre").Value,
                               publish_date = DateTime.Parse(book.Element("publish_date").Value),
                               description  = book.Element("title").Value
                           };

            foreach (var p in allBooks)
            {
                var price   = p.price;
                var title   = p.title;
                var p_date  = p.publish_date.ToShortDateString();

                Console.WriteLine("Title: \"{0}\",\n\tPrice: ${1},\n\tFirst Published: {2}\n", title, price, p_date);
            }
            Console.ReadLine();
        }
    }
}
