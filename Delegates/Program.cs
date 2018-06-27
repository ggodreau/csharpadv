using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // tricky part; you must assign the method you want to apply
            // to the DELEGATE function
            Action<Photo, string> filterHandler = filters.ApplyBrightness;
            // you can treat the delegate function as a list of method objects
            // ...i.e. a stack of things to do, and you push successive methods
            // onto it. This is called multicast delegate (invocationList property)
            filterHandler += filters.ApplyContrast;

            // this is of type: Delegates.PhotoProcessor + PhotoFilterHandler
            Console.WriteLine(filterHandler.GetType());
            // target is: Delegates.PhotoFilters
            Console.WriteLine(filterHandler.Target);
            // method is: Void ApplyContrast(Delegates.Photo)
            Console.WriteLine(filterHandler.Method);
            photoProcessor.Process("c:\\photo.jpg", filterHandler);
        }
    }
}
