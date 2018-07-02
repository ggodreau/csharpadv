using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class YouTubeException : System.Exception
    {
        // this constructor takes a message and innerException as arguments
        // and returns them to the base object (not 100% sure)
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
