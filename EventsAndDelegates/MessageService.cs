using System;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending message...");
            Console.WriteLine("message args = " + e.video.Title);
        }
    }
}
