using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        public static int _n = 5;

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            Console.WriteLine(books.FindAll(ct10).Count);
            foreach (Book biik in books.FindAll(ct10))
            {
                Console.WriteLine(biik.Title);
            }
        }

        // this is my predicate, the thing that returns true
        // if a condition is met and false otherwise.
        // used for the List<>.FindAll(Predicate<T>) method
        // above
        static bool ct10(Book book)
        // cheaper than 10 doll hairs
        {
            if (book.Price < 10) { return true; }
            else { return false; }
        }
    }
}
