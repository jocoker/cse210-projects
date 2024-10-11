using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("An Inside Look at Montezuma Castle", "The Old Ranger", 1819);

        Comment video1Comment1 = new Comment("John", "This video is truly inspiring! I love how you explore the ancient ruins and share their history.");
        Comment video1Comment2 = new Comment("Paul", "Your content always surprises me. I'm glad you're showcasing the beauty of our state.");
        Comment video1Comment3 = new Comment("Mary", "Wonderful! I would love to visit this place someday.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Grand Canyon 101 for First-Time Visitors", "Mike Monroe", 675);

        Comment video2Comment1 = new Comment("Diego", "What an incredible adventure! I love how you showcase the mysteries of the Grand Canyon and invite us to discover more about our history.");
        Comment video2Comment2 = new Comment("Emily", "Your videos always transport me to new places. Thank you for sharing these hidden gems.");
        Comment video2Comment3 = new Comment("Kayden", "The views are simply breathtaking. I'm proud to be from Arizona.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Welcome to Antelope Canyon", "Jerry Arizona", 451);

        Comment video3Comment1 = new Comment("Zachary", "Antelope Canyon is gorgeous, but I'm so glad that my wife and I went there with two friends in 1989. It was still only known by word of mouth then.");
        Comment video3Comment2 = new Comment("Shannon", "As a hiker, that kind of looked like hell. All that beauty, and you can't really enjoy it.");
        Comment video3Comment3 = new Comment("Allan", "Now I have to go! Thanks for posting this is pretty awesome.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}