using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2;

            // won't work
            // if(date != null) { date2 = date; }
            
            // this does work tho; it is the long form of the null coalescing operator
            if(date != null) { date2 = date.GetValueOrDefault(); }
            else { date = DateTime.Today; }

            // null coalescing operator (double ??'s). behaves like below code (ternary operator)
            // variable = condition ? ifTrue : ifFalse
            // date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Now;
            date2 = date ?? DateTime.UtcNow;
            Console.WriteLine(date2);
        }
    }
}
