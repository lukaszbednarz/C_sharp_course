using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroupAndJoinData;

namespace LINQ_Join_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generate data
            Database citiesAndCountries = new Database();

            // Join cities and countries and print alphabeticaly ordered list of cities, together with it's country and population
            ColorConsole.WriteLine("City, Country, Country Population", ConsoleColor.Green);

            var query1 = from cities in citiesAndCountries.Cities.OrderBy(p => p.CityName)
                         join countries in citiesAndCountries.Countries on cities.CountryName equals countries.Name
                         select new {CityName = cities.CityName, Country = countries.Name, Population = countries.Population};

            foreach (var city in query1)
            {
                ColorConsole.WriteLine(string.Format("{0}, {1}, {2}", 
                                                        city.CityName, 
                                                        city.Country, 
                                                        city.Population.ToString("#,#")), 
                                       ConsoleColor.Green);
            }

            // List all Countries with their cities.
            ColorConsole.WriteLine("\nAll Countries and their cities\n", ConsoleColor.Green);

            var query2 = from countries in citiesAndCountries.Countries.OrderBy(p => p.Name)
                         join cities in citiesAndCountries.Cities on countries.Name equals cities.CountryName into citiesList
                         select new { CountryName = countries.Name, Cities = citiesList.OrderBy(e => e.CityName) };

            foreach (var country2 in query2)
            {
                ColorConsole.WriteLine("\n" + country2.CountryName + "\n" , ConsoleColor.Green);
                if (country2.Cities.Any())
                {
                    foreach (var city2 in country2.Cities)
                    {
                        ColorConsole.WriteLine("-- " + city2.CityName, ConsoleColor.Green);
                    }
                }
            }


            // List all Countries with their cities and percentage of city population of total country population
            ColorConsole.WriteLine("\nAll Cities and their percentage of thier country's population.\n", ConsoleColor.Green);

            var query3 = from country in citiesAndCountries.Countries.OrderBy(p => p.Name)
                         join cities in citiesAndCountries.Cities on country.Name equals cities.CountryName into citiesList
                         select new { Country = country.Name, Population = country.Population, Cities = citiesList.OrderByDescending(e => e.CityPopulation) };

            foreach (var country in query3)
            {
                if (country.Cities.Any())
                {
                    ColorConsole.WriteLine("\n" + country.Country + country.Population.ToString("' ( '#,# ' )'"), ConsoleColor.Green);
                    foreach (var city in country.Cities)
                    {
                        ColorConsole.WriteLine("-- " + city.CityName + (((double)city.CityPopulation)/((double)country.Population)).ToString("' ( '0.00%' )'"), ConsoleColor.Green);
                    }
                }
            }

        }
    }
}
