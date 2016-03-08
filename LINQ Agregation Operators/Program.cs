using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroupAndJoinData;

namespace LINQ_Agregation_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Generate data

            Database citiesAndCountries = new Database();
                        
            //What is the total population in all the cities?
            var count = citiesAndCountries.Cities.Sum(p => p.CityPopulation);

            ColorConsole.WriteLine("Total city population: " + count.ToString("#,#"), ConsoleColor.Green);

            //What is the total population in all the countries?
            var worldPopulation = citiesAndCountries.Countries.Sum(p => (UInt32)p.Population);
            ColorConsole.WriteLine("Total country population: " + count.ToString("#,#"), ConsoleColor.Green);

            //How many countries have a population greater than 100,000,000?
            count = citiesAndCountries.Countries.Count(p => p.Population > 100000000);
            ColorConsole.WriteLine("Number of large countries: " + count.ToString("#,#"), ConsoleColor.Green);

            //What is the population of the largest city?
            var population = citiesAndCountries.Cities.Max(p => p.CityPopulation);
            ColorConsole.WriteLine("Population of largest city: " + population.ToString("#,#"), ConsoleColor.Green);

            //What is the largest city?

            var city = (from cities in citiesAndCountries.Cities
                        where cities.CityPopulation == population
                        select cities).First();

            ColorConsole.WriteLine("Largest city: " + city.CityName + population.ToString(" (#,#)"), ConsoleColor.Green);

            _AskForKeyPress();



        }

        private static void _AskForKeyPress()
        {
            ColorConsole.WriteLine("Press any key to continue...", ConsoleColor.Green);
            Console.ReadKey(true);
        }
    }
}
