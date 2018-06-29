using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){ Title="foo", Price=2.99 },
                new Book(){ Title="bar", Price=3.99 },
                new Book(){ Title="boo", Price=4.99 },
                new Book(){ Title="bar", Price=5.99 }
            };
        }
    }
}