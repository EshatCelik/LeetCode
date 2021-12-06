using System;
using System.Collections.Generic;
using System.Threading;

namespace OOP
{
    internal class Program
    {
        public class Video 
        {
            public string Title { get; set; }
        }
        public class VideoEncoder
        {
            public delegate void VideoEncodedEventHandler(object sourc, EventArgs args);
            public event VideoEncodedEventHandler VideoEncoded;

            public void Encode(Video video)
            {
                Console.WriteLine(" Encoding video....");
                Thread.Sleep(3000);
                OnVideoEncoding();

            }
            protected virtual void OnVideoEncoding()
            {
                if (VideoEncoded!=null)
                {
                    VideoEncoded(this,EventArgs.Empty);
                }
            }
        }

        public class MessageService
        {
            public void OnVideoEncoded(object sourc,EventArgs args)
            {
                Console.WriteLine("Message Service : sendign a text message ...");
            }
        }
       
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Title 1" };

            var videoEncoder=new VideoEncoder();
            var messgeService=new MessageService();

            videoEncoder.VideoEncoded += messgeService.OnVideoEncoded;

            videoEncoder.Encode(video);
            
        }


    }
}
