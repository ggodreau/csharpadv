using System;

namespace Delegates
{
    class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        // the second argument into Process()
        // indicates where to delegate TO
        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {
            var photo = new Photo();
            photo.Load(path);
           
            photoFilterHandler(photo);
            photo.Save();

        }
    }
}