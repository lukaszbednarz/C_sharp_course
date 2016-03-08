using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Use an array initializer here
            var books = new Book[4]{new Book(0321751043, "The Art of Computer Science", "Donald E. Knuth"),
                                    new Book(0521431085, "Numerical Recipes in C", "William H. Press"),
                                    new Book(1555580416, "Common Lisp", "Guy L. Steele Jr."),
                                    new Book(0201633612, "Design Patterns", "Erich Gamma" , "Richard Helm", "Ralph Johnson", "John Vlissides")};
            
            // TODO: Modify Book constructor accept a list of authors
            // new Book(0201633612, "Design Patterns", "Erich Gamma" , "Richard Helm", "Ralph Johnson", "John Vlissides"),

            // TODO: Convert Book.Comments to be a dynamic collection
            books[0].Comments.Add("This one is on my shelf.");
            books[0].Comments.Add("Reference it every day.");
            books[1].Comments.Add("Gave it away after my college course.");
            books[1].Comments.Add("Changed my life.");
            books[1].Comments.Add("Every developer should read.");
            books[2].Comments.Add("I've read it five times!");
            books[2].Comments.Add("There are better books out there.");
            books[3].Comments.Add("Highly recommend.");

            // create a book collection
            var csBooks = new BookCollection();
            csBooks.AddBooks(books);

            // get a single book
            Console.WriteLine("Search results **************************");
            var bookByIsbn = csBooks.GetBookByISBN(0201633612UL);
            BookUtils.Show(bookByIsbn);

            // print all the books
            Console.WriteLine("All books **************************");
            for (int i = 0; i < csBooks.BookCount; i++)
            {
                // TODO: Add an indexer to the BooksCollection
                var book = csBooks[i];
                BookUtils.Show(book);
            }

            Console.ReadKey();
        }
    }
}
