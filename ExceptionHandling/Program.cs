using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var myCalc = new Calculator();
                Console.WriteLine(myCalc.Divide(5, 0));
            }
            // put an argument next to Exception so we can use the thrown exception in our msg
            // put the most specific catches at the top and the most generic catches below
            // note that these are all overloads with slightly different signatures
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("I'm pretty sure you can't " + ex.Message);
            }
            // most generic catch (catches System.Exception, the parent class of all exceptions)
            catch (Exception ex)
            {
                Console.WriteLine("Sh** just got f****d by " + ex.Message);
                //throw new System.UnauthorizedAccessException().GetBaseException();
            }
        }
    }
}
