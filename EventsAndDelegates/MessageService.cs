using System;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: sending message...");
        }
    }
}
