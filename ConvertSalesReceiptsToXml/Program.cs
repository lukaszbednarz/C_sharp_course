using System;
using System.Linq;
using System.Xml.Linq;
using LearningLine.Practice;

#if !AFTER

namespace LearningLine.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var receipts = SalesReceiptFile.Read(@"..\..\SalesReceipts.bin");

            // TODO: write the receipts data to an XML file
            XNamespace ns = XNamespace.Get("urn:learning-line:practice");

            XElement root = new XElement(ns + "receipts", 
                                                    from rec in receipts
                                                    select new XElement(ns + "receipt", new XAttribute("id", rec.Id),
                                                                                   new XElement(ns + "date", rec.Date.ToString()),
                                                                                   new XElement(ns + "quantity", rec.Quantity),
                                                                                   new XElement(ns + "description", rec.Description)));

            root.Save(@"..\..\SalesReceipts.xml");


            Console.ReadLine();

        }
    }
}

#endif
