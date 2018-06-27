using System;

namespace Delegates
{
    class PhotoProcessor
    {
        //public delegate void PhotoFilters(Photo photo); 
        // there are .NET built-in GENERIC delgate methods, Action and Func
        // ACTION: takes paramaters but returns no values
        // FUNC: takes paramaters and returns value(s)
        //System.Action<>;
        //System.Func<>;

        // the second argument into Process()
        // indicates where to delegate TO
        public void Process(string path, Action<Photo, string> photoFilterHandler)
        {
            var photo = new Photo();
            photo.Load(path);
           
            photoFilterHandler(photo, "foo");
            photo.Save();

        }
    }
}