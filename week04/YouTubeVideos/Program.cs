using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // FIRST VIDEO
        Video video1 = new Video(
            "Introduction to C#",
            "Mathias Abbas",
            300
        );

        video1.AddComment(new Comment(
            "John",
            "This is a very helpful tutorial."
        ));

        video1.AddComment(new Comment(
            "Mary",
            "I enjoyed learning C#."
        ));

        video1.AddComment(new Comment(
            "David",
            "Please upload more lessons."
        ));

        // SECOND VIDEO
        Video video2 = new Video(
            "Learning Python",
            "Mathias Abbas",
            450
        );

        video2.AddComment(new Comment(
            "Peter",
            "Great explanation."
        ));

        video2.AddComment(new Comment(
            "Sarah",
            "I learned something new."
        ));

        video2.AddComment(new Comment(
            "James",
            "Very informative video."
        ));

        // THIRD VIDEO
        Video video3 = new Video(
            "Web Development Basics",
            "Mathias Abbas",
            600
        );

        video3.AddComment(new Comment(
            "Michael",
            "HTML is interesting."
        ));

        video3.AddComment(new Comment(
            "Grace",
            "Thank you for sharing."
        ));

        video3.AddComment(new Comment(
            "Daniel",
            "I look forward to more tutorials."
        ));

        // CREATE A LIST OF VIDEOS
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        // DISPLAY VIDEOS
        Console.WriteLine("YOUTUBE VIDEO MANAGEMENT SYSTEM");
        Console.WriteLine("================================");

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}