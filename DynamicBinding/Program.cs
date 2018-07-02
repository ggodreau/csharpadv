using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object myObj = "greg";
            // get the hash code with the method
            //myObj.GetHashCode();

            // reflection example (gets the method to return, then invokes it
            var methodInfo = myObj.GetType().GetMethods();
            //foreach (System.Reflection.MethodInfo method in methodInfo) { Console.WriteLine(method); }

            // try to get the GetHashCode() method...
            Console.WriteLine(myObj.GetType().GetMethod("GetHashCode()"));

            // setting dynamic variables
            dynamic a = 10; // is dynamic
            dynamic b = 5; // is also dynamic
            var c = a + b; // BECOMES dynamic upon assignment, due to a and b being dynamic
        }
    }
}
