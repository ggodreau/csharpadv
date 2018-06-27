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
            int factor = 10;

            // foo is the input argument, 20
            Func<int, int> multiplyBy = foo => _n * factor * foo;
            Console.WriteLine(multiplyBy(20).ToString());
        }

    }
}
