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
            // lambda expression below
            // not sure why you don't need Func<> with this; 
            // couldn't get it to work that way. damnit
            foreach (Book foo in books.FindAll(book => book.Price < 10))
            {
                Console.WriteLine("Title: " + foo.Title + " price: " + foo.Price);
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
