using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3EventDelegateVideoEncode
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video(); ;
            video.Title = "Title 1";
            VideoEncoder encoder = new VideoEncoder();
            encoder.Encode(video);

        }
    }
    public class Video {
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

    }

    public class VideoEncoder {
        //1. Define a delegate
        private delegate void VideoEncoderEventHandler(string ServiceType);
        //2. Define an event based on the delegate
        //3. Raise or publish the event
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
