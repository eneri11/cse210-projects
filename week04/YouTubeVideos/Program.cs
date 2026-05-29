using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        // Create video list
        List<Video> videos = new List<Video>();

        // ------------- VIDEO 1 ---------------
        Video video1 = new Video("C# Basics Tutorial", "CodeAcademy", 600);
        video1.AddComment(new Comment("Jean", "Very helpful!"));
        video1.AddComment(new Comment("John", "I finally understand classes."));
        video1.AddComment(new Comment("Mark", "Awesome explanation."));

        // ------------- VIDEO 2 ---------------
        Video video2 = new Video("OOP Explained Simply", "TechWorld", 750);
        video2.AddComment(new Comment("Gary", "This made it clear."));
        video2.AddComment(new Comment("Sophia", "Abstraction is now easy."));
        video2.AddComment(new Comment("Noah", "Nice examples!"));

        // ------------- VIDEO 3 ---------------
        Video video3 = new Video("Gaming Highlights", "ProGamer", 420);
        video3.AddComment(new Comment("Alex", "So Cool!"));
        video3.AddComment(new Comment("Emma", "That play was insane!"));
        video3.AddComment(new Comment("Chris", "GG!"));

        //Add video to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // ----------------- DISPLAY --------------------
        foreach (Video video in videos)
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }

    }
}