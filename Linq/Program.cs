using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBooks = new BookRepository().GetBooks();
            //.Where(book => book.price < 10);
            foreach (Book book in myBooks.Where(b => b.Price < 10))
            { Console.WriteLine("title: " + book.Title + " price: " + book.Price); };
        }
    }
}
