using System;

namespace Delegates
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyBrightness(Photo photo, string message)
        {
            Console.WriteLine("Apply brightness" + message);
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void ApplyContrast(Photo photo, string message)
        {
            Console.WriteLine("Apply contrast" + message);
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}
