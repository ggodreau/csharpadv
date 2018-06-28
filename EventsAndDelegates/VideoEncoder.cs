using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // how to use
        // 1 - define a delegate
        // 2 - define an event based on that delegate
        // 3 - raise the event

        // 1: define the delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2: define the event based on the above delegate (it is of return type 'event')
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("encoding video...");
            Thread.Sleep(3000);

            // call the event handler
            OnVideoEncoded();
        }

        // 3: - raise the event. .NET convention is to make this
        // a protected, virtual, void method. They also are named
        // 'On____', like OnThingFinished
        protected virtual void OnVideoEncoded()
        {
            // check to see if there are any pre-existing subscribers
            if(VideoEncoded != null)
            {
                // use EventArgs.Empty, not null here
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}