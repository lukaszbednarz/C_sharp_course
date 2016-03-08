using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _04_Create_an_XML_document_using_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var winners = UCL.GetWinners();
            XElement root = new XElement("winners");

            foreach (Winner w in winners)
            {
                // TODO
                root.Add(new XElement("winner", new XElement("name", w.Name),
                                                new XElement("country", w.Country),
                                                new XElement("year", w.Year)));
            }

            Console.WriteLine(root.ToString());

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Encapsulates information about a UEFA Champions League winner
    /// </summary>
    class Winner
    {
        string _name;
        string _country;
        int _year;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Winner() { }
        public Winner(string name, string country, int year)
        {
            _name = name;
            _country = country;
            _year = year;
        }
    }

    /// <summary>
    /// utility class with a single method returning the sequence
    /// of winners
    /// </summary>
    class UCL
    {
        /// <summary>
        /// returns a sequence of all UCL winners
        /// </summary>
        /// <returns>IEnumerable<Winner></returns>
        public static IEnumerable<Winner> GetWinners()
        {
            Winner[] winners =
        {
            new Winner("Barcelona", "Spain", 2006),
            new Winner("Liverpool", "England", 2005),
            new Winner("FC Porto", "Portugal", 2004),
            new Winner("AC Milan", "Italy", 2003),
            new Winner("Real Madrid", "Spain", 2002),
            new Winner("Bayern Munchen", "Germany", 2001),
            new Winner("Real Madrid", "Spain", 2000),
            new Winner("Manchester Utd.", "England", 1999),
            new Winner("Real Madrid", "Spain", 1998),
            new Winner("Borussia Dortmund", "Germany", 1997),
            new Winner("Juventus", "Italy", 1996),
            new Winner("AFC Ajax", "Netherlands", 1995),
            new Winner("AC Milan", "Italy", 1994),
            new Winner("Olympique de Marseille", "France", 1993)
        };

            return winners;
        }
    }

}
