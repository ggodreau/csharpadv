using System;

namespace Delegates
{
    class Photo
    {
        private Photo _photo;

        public Photo Load(string path)
        {
            // loads photo
            return _photo;
        }

        public void Save()
        {
            Console.WriteLine("photo saved");
        }
    }
}
