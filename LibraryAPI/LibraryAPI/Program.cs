using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Title = "Intro to C#";
            book.ISBN = 1234567;
            book.Price = 12.34M;
            book.Count = 5;
            book.PublishedYear = new DateTime(2010, 1, 1);

            Library.AddBook(book);

            Library.PrintBooks();
        }
    }
}
