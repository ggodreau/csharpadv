using System;

namespace EventsAndDelegates
{
    public class MailService
    // sends an email once the video is encoded
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: sending emair...");
        }
    }
}
