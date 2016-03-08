using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksCollection
{
    class Book
    {
        public ulong ISBN { get; private set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }

        // TODO: Convert this static array to be a dynamic collection
        public List<string> Comments { get; private set; }

        // TODO: Accept an array of authors
        public Book(ulong isbn, string title, params string[] authors)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            Comments = new List<String>();
        }
    }
}
