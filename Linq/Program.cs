using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBooks = new BookRepository().GetBooks();
            
            // filter with Where()
            foreach (Book book in myBooks.Where(b => b.Price < 4))
            { Console.WriteLine("title: " + book.Title + " price: " + book.Price); };

            // sort with OrderByDescending()
            foreach (Book book in myBooks.OrderByDescending(b => b.Price))
            { Console.WriteLine("price sort: " + book.Price); };

            // chain together and select the string property
            foreach (string title in myBooks
                .Where(b => b.Price < 4)
                .OrderByDescending(b => b.Price)
                .Select(b => b.Title))
            { Console.WriteLine(title); };

            // linq query operators
            Console.WriteLine("linq query operator below: ===");
            var cheaperBooks =
                from b in myBooks
                where b.Price < 9
                orderby b.Price ascending
                select b.Title;

            foreach (string title in cheaperBooks) { Console.WriteLine(title); }

            // other helpful methods in Linq
            // .First() - gets the first element in an array (you can optionally put a filter condition in here, and it'll return the first from the filtered list)
            // .FirstOrDefault() - gets the first, but if the first isn't there it throws exception instead of crashing
            // .Single() / SingleOrDefault() - gets the only result ONLY IF there is a single result (including filters); otherwise throws InvalidOperationException
        }
    }
}
