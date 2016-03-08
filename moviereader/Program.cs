using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace MovieReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading movies...");
            //IList<Movie> movies = GetMovies();
            IEnumerable<Movie> movies = GetMoviesOneAtaTime("dupa", 10);

            foreach (Movie m in movies)
            {
                Console.WriteLine(m.Title);
            }

            Console.ReadKey();
        }

        private static IEnumerable<Movie> GetMoviesOneAtaTime(string pattern, uint maxResults)
        {
            using (StreamReader rdr = new StreamReader("movies.txt"))
            {
                string lastTitle = String.Empty;
                uint resCount = 0;
                while (!rdr.EndOfStream && resCount < maxResults)
                {
                    string line = rdr.ReadLine();
                    Match regex = Regex.Match(line, "^([^{\t]*" + pattern + "[^{\t]*).*(\\d{4})$");
                    if (regex.Success)
                    {
                        string title = regex.Groups[1].Captures[0].Value.Trim();
                        string year = regex.Groups[2].Captures[0].Value.Trim();
                        if (title != lastTitle)
                        {
                            resCount++;
                            lastTitle = title;
                            yield return new Movie(title, year);
                            
                        }
                    }
                }
            } 
        }

        static IList<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();

            using (StreamReader rdr = new StreamReader("movies.txt"))
            {
                string lastTitle = String.Empty;
                while (!rdr.EndOfStream)
                {
                    string line = rdr.ReadLine();
                    Match regex = Regex.Match(line, "^([^{\t]*).*(\\d{4})$");
                    if (regex.Success)
                    {
                        string title = regex.Groups[1].Captures[0].Value.Trim();
                        string year = regex.Groups[2].Captures[0].Value.Trim();
                        if (title != lastTitle)
                        {
                            movies.Add(new Movie(title, year));
                            lastTitle = title;
                        }
                    }
                }
            }

            return movies;
        }
    }

    class Movie
    {
        public string Title { get; protected set; }
        public string Year { get; protected set; }
        public Movie(string title, string year)
        {
            Title = title;
            Year = year;
        }
    }
}
