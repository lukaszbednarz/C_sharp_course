using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroupAndJoinData;


namespace LINQ_Groupping_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate data
            Database citiesAndCountries = new Database();

            // Produce list of Countries, groupped by first letter, sorted alphabeticaly
            var grouppedCities = (from p in citiesAndCountries.Countries.OrderBy(e => e.Name)
                                 group p by p.Name[0]
                                 into g
                                 select g).OrderBy(e => e.Key);

            ColorConsole.WriteLine("Countries, grouped by first letter, sorted alphabetically.", ConsoleColor.Green);
            
            foreach (var group in grouppedCities)
            {
                ColorConsole.WriteLine(group.Key.ToString(), ConsoleColor.Green);
                
                foreach (var city in group)
                {
                    ColorConsole.WriteLine(string.Format("\t{0,-10}", city.Name), ConsoleColor.Green);
 
                }
            
            }

            // Produce list of Countries, groupped by first letter, sorted by population

            var grouppedCities2 = (from p in citiesAndCountries.Countries.OrderBy(e => e.Population)
                                  group p by p.Name[0]
                                      into g
                                      select g).OrderBy(e => e.Key);

            ColorConsole.WriteLine("Countries, grouped by first letter, but sorted by population within each letter.", ConsoleColor.Green);
            
            foreach (var group in grouppedCities2)
            {
                ColorConsole.WriteLine(group.Key.ToString(), ConsoleColor.Green);

                foreach (var city in group)
                {
                    ColorConsole.WriteLine(string.Format("\t{0,-10}\t", city.Name) + city.Population.ToString("(#,#)"), ConsoleColor.Green);

                }

            }

            // Produce list of subtotal population of countries starting by each letter.

            var populations = (from p in citiesAndCountries.Countries.OrderBy(e => e.Population)
                               group p by p.Name[0]
                                   into g
                                   select new { Letter = g.Key, Population = g.Sum(p => p.Population)}
                                   ).OrderBy(e => e.Letter);

            ColorConsole.WriteLine("Subtotal by first letter the country population", ConsoleColor.Green);
            foreach (var element in populations)
            {
                
                ColorConsole.WriteLine(string.Format("{{ FirstLetter = {0}, Population = {1}}}", element.Letter, element.Population), ConsoleColor.Green);

             }

            // Produce list of subtotal population of countries starting by each letter, sorted by subtotal.

            populations = (from p in citiesAndCountries.Countries.OrderBy(e => e.Population)
                               group p by p.Name[0]
                                   into g
                                   select new { Letter = g.Key, Population = g.Sum(p => p.Population)}
                                   ).OrderByDescending(e => e.Population);

            ColorConsole.WriteLine("Subtotal by first letter the country sorted by subtotal", ConsoleColor.Green);
            foreach (var element in populations)
            {
                ColorConsole.WriteLine(string.Format("{{ FirstLetter = {0}, Population = {1}}}", element.Letter, element.Population), ConsoleColor.Green);
            }

            // Produce list of countries groupped my magnitude of population
            var grouppedCities3 = (from p in citiesAndCountries.Countries.OrderByDescending(e => e.Population)
                                   group p by (int)Math.Ceiling(Math.Log10(p.Population))-1
                                   into g
                                   select new {Population = Math.Pow(10, g.Key), Count = g.Count(), Countries = g  }).OrderByDescending(e => e.Population);

            ColorConsole.WriteLine("Subtotal by first letter the country sorted by subtotal", ConsoleColor.Green);
            foreach (var group in grouppedCities3)
            {
                ColorConsole.WriteLine(string.Format("More than {0}: ({1} countries)", group.Population.ToString("#,#"), group.Count.ToString()), ConsoleColor.Green);

                foreach (var city in group.Countries)
                {
                    ColorConsole.WriteLine(string.Format("\t{0,-10}\t", city.Name) + city.Population.ToString("(#,#)"), ConsoleColor.Green);

                }

            }
        }
    }
}
