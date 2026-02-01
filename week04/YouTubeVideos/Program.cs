using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Created video1 and added comments
        Video video1 = new Video("Learning C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Chris", "This made C# much clearer."));
        videos.Add(video1);

        // Created video2 and added comments
        Video video2 = new Video("Top 10 Programming Tips", "Bright", 480);
        video2.AddComment(new Comment("Dana", "Tip #4 was amazing."));
        video2.AddComment(new Comment("Eli", "Loved the examples."));
        video2.AddComment(new Comment("Frank", "Please make a follow-up."));
        videos.Add(video2);

        // Created video3 and added comments
        Video video3 = new Video("Understanding OOP Concepts", "BYU-IDAHO", 720);
        video3.AddComment(new Comment("Grace", "Abstraction finally makes sense."));
        video3.AddComment(new Comment("Hannah", "Clear and concise."));
        video3.AddComment(new Comment("Ian", "Great visuals."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }

        // Pause console
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
