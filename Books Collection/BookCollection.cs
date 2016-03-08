using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksCollection
{
    class BookCollection
    {
        // TODO: Store books in a Dictionay<K,V>
        Dictionary<ulong, Book> Books = new Dictionary<ulong, Book>();

        public Book this[int index]
        {
            get
            {
                return Books.ElementAt<KeyValuePair<ulong, Book>>(index).Value;
            }

            
        }
        public void AddBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Books[book.ISBN] = book;
            }
        }

        public int BookCount
        {
            get
            {
                return Books.Count;
            }
        }

        public Book GetBookByISBN(ulong id)
        {
            // TODO: Pull the book out of the Dictionary<K,V>
            return Books[id];
        }
    }
}
