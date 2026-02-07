using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Code in C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "This was so clear!"));
        video1.AddComment(new Comment("Bob", "I finally understand classes."));
        video1.AddComment(new Comment("Charlie", "Can you do one on Python?"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Programming Languages", "Jane Smith", 900);
        video2.AddComment(new Comment("Dave", "Great list."));
        video2.AddComment(new Comment("Eve", "I can't stop laughing."));
        video2.AddComment(new Comment("Frank", "Is it difficult to learn?"));
        videos.Add(video2);

        Video video3 = new Video("Minecraft Survival Ep. 1", "Gamer123", 1200);
        video3.AddComment(new Comment("Grace", "Don't dig straight down!"));
        video3.AddComment(new Comment("Heidi", "Nice house build."));
        video3.AddComment(new Comment("Ivan", "When is the next episode?"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            
            // Using the Abstraction method requested
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}"); 
            Console.WriteLine("Comments:");

            foreach (Comment c in video._comments)
            {
                Console.WriteLine($"- {c._name}: {c._text}");
            }
        }
    }
}