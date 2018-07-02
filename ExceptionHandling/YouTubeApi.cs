using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class YouTubeApi
    {
        public List<Video> GetVideos()
        {
            try
            {
                // get videos here from API
                // return new List<Video>();
                throw new System.AppDomainUnloadedException("faaack!!");
            }
            // this will catch the AppDomain exception from above
            catch (Exception x)
            {
                // log to a file here if you wanted to
                // x.HelpLink = "ya dun fuckedup";

                // this allows us to insert a custom message, but we also
                // have to create our own Exception class that inherits from 
                // System.Exception, called YouTubeException.
                throw new YouTubeException("couldn't get vids", x);
            }
        }
    }
}
