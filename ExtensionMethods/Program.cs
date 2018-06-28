using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a longass blog post that I'm supposed to shorten with an extension method";
            Console.WriteLine(post.Shorten(5)); // this is going to be my future extension method... hopefully
        }
    }
}