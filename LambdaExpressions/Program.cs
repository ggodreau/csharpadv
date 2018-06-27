using System;

namespace LambdaExpressions
{
    class Program
    {
        public static int _n = 5;

        static void Main(string[] args)
        {
            Console.WriteLine(new Program().Squared(_n).ToString());
        }

        public int Squared(int n)
        {
            return n * n;
        }
    }
}
