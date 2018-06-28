using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {

        // the (object source) arguments are implicit with EventHandler<>
        // below is the NON-generic form
        public event System.EventHandler<VideoEventArgs> VideoEncoded;
        // here is the GENERIC form, which you'd use if you didn't need to pass args
        // public event System.EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("encoding video...");
            Thread.Sleep(3000);

            // call the event handler
            OnVideoEncoded(video);
        }

        // 3: - raise the event. .NET convention is to make this
        // a protected, virtual, void method. They also are named
        // 'On____', like OnThingFinished
        protected virtual void OnVideoEncoded(Video video)
        {
            // check to see if there are any pre-existing subscribers
            if(VideoEncoded != null)
            {
                var vidArgs = new VideoEventArgs();
                vidArgs.video = video;
                VideoEncoded(this, vidArgs);
            }
        }
    }
    public class VideoEventArgs : EventArgs
    {
        public EventsAndDelegates.Video video { get; set; }
    }
}