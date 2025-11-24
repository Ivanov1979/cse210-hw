using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold all the videos
            List<Video> videos = new List<Video>();

            // ==== Video 1 ====
            Video video1 = new Video("C# Classes Explained", "Code Academy", 600);
            video1.AddComment(new Comment("Iván", "This really helped me understand classes!"));
            video1.AddComment(new Comment("Maria", "Very clear explanation, thanks."));
            video1.AddComment(new Comment("John", "Could you make one about interfaces?"));
            videos.Add(video1);

            // ==== Video 2 ====
            Video video2 = new Video("Math Tricks with Fractions", "Teacher Ana", 450);
            video2.AddComment(new Comment("Carlos", "Now I finally get fractions."));
            video2.AddComment(new Comment("Lucía", "Perfect for my homework."));
            video2.AddComment(new Comment("Pedro", "Please do a sequel with decimals."));
            videos.Add(video2);

            // ==== Video 3 ====
            Video video3 = new Video("Introduction to General Relativity", "Physics World", 1200);
            video3.AddComment(new Comment("Sofia", "Mind-blowing content."));
            video3.AddComment(new Comment("Diego", "I love the visuals."));
            video3.AddComment(new Comment("Elena", "Could you slow down a little?"));
            videos.Add(video3);

            // (Optional) Video 4
            Video video4 = new Video("Web Development Basics", "Dev Starter", 900);
            video4.AddComment(new Comment("Luis", "HTML and CSS finally make sense!"));
            video4.AddComment(new Comment("Nina", "Great intro for beginners."));
            video4.AddComment(new Comment("Rafa", "Waiting for the JavaScript part."));
            videos.Add(video4);

            // ==== Display all videos and their comments ====
            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
            }

            // Keep console window open (optional depending on how you run it)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
