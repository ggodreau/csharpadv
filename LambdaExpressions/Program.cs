using System;

namespace LambdaExpressions
{
    class Program
    {
        public static int _n = 5;

        static void Main(string[] args)
        {
            // Console.WriteLine(new Program().Squared(_n).ToString());

            //Func<input_type, output_type>
            Func<int, int> squareDelg = Squared;
            Console.WriteLine(squareDelg(_n).ToString());
        }

        public static int Squared(int n)
        {
            return n * n;
        }
    }
}
