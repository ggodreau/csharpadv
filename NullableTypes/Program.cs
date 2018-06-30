using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // can't set value types to null; the below won't work
            // DateTime birthday = null;

            // have to use Nullable as below
            System.Nullable<DateTime> nullday = null;
            Console.WriteLine("nullday = " + nullday);

            // or the shorthand is to use a question mark following the datatype
            DateTime? birthday = null;
            Console.WriteLine("birthday = " + birthday);

            // lets get the values
            Console.WriteLine("getvalordef = " + birthday.GetValueOrDefault());
            Console.WriteLine("hasval? = " + birthday.HasValue);
            // below will return a null reference exception error
            // Console.WriteLine("val = " + birthday.Value);
        }
    }
}
