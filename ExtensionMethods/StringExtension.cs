using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        // this method takes 'this' as an argument. That is the blog post text
        // object, which of course is a string
        public static string Shorten(this String str, int numberOfWords)
        {
            string outstr = "";
            if(numberOfWords == 0) { return ""; }
            foreach(string word in str.Split().Take(numberOfWords))
            {
                outstr += word + " ";
            }
            outstr = outstr.Substring(0, outstr.Length - 1);
            outstr += "...";
            return outstr;
        }
    }
}