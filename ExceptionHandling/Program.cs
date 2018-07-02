using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
               // var streamReader = new StreamReader("C:\\Users\\user\\Documents\\udemy\\csharpadv\\myFile.txt");
            try
            {
                streamReader = new StreamReader("C:\\Users\\user\\Documents\\udemy\\csharpadv\\myFile.txt");
                Console.WriteLine(streamReader.ReadLine());
                // you can manually throw an exception, even if nothing's really wrong:
                throw new System.Exception("what the hell!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sh** just got f****d by " + ex.Message);
            }
            // the finally block ALWAYS GETS RUN after try or catch; doesn't matter if
            // the try succeeds or if the catch catches it. This is used for garbage
            // collection on unmanaged code (namely, reading files from disk, databases, network, etc)
            finally
            {
                Console.WriteLine("collecting garbaj...");
                streamReader?.Dispose(); // frees any caches resources related to reading the file 
            }
        }
    }
}
