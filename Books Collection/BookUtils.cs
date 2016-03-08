using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksCollection
{
    static class BookUtils
    {
        public static void Show(Book book)
        {
            if (book != null)
            {
                Console.WriteLine("{0} (#{1:D10})", book.Title, book.ISBN);
                Console.Write("by ");

                var authorsList = new StringBuilder();
                foreach (var author in book.Authors)
                {
                    if (authorsList.Length > 0)
                        authorsList.Append(", ");
                    authorsList.Append(author);
                }

                Console.WriteLine(authorsList);

                foreach (var cmt in book.Comments)
                {
                    Console.WriteLine("\"{0}\"", cmt);
                }
            }
            Console.WriteLine();
        }
    }
}
