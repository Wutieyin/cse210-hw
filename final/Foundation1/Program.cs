using System;
using System.Collections.Generic;
using System.Security.Authentication;


class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Creating videos
        videos.Add(new Video("Introduction to Programming with classes", "Code Master", 180));
        videos.Add(new Video("How to Make a Delicious Smoothie", "Smoothie Queen", 240));
        videos.Add(new Video("10-Minute Full Body Workout at Home", "Fit King", 600)); 

        // Adding comments to videos
        videos[0].AddComment("Alice", "Great intro, looking forward to more!");
        videos[0].AddComment("Bob", "awsome explanations, thanks!");
        videos[1].AddComment("Elizaberth", "Yummy! I'm trying this recipe tomorrow.");
        videos[1].AddComment("Rosemary", "My kids loved it, thank you!");
        videos[2].AddComment("Paul", "Feeling energized after this workout, great job!");
        videos[2].AddComment("Frank", "Just what I needed for my busy schedule!");

        System.Console.WriteLine();

        // Displaying video info
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
