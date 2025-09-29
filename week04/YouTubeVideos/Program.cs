using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to cook pancakes", "James Cool", 120);
        Video video2 = new Video("Visiting New York", "Robert Tram", 300);
        Video video3 = new Video("How to be a better student", "Stewart Mark", 160);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        video1.StoreComment(new Comment("Tom", "I love pancakes"));
        video1.StoreComment(new Comment("Robert", "best recipe"));
        video1.StoreComment(new Comment("Sam", "I will share with my familiy"));
        video2.StoreComment(new Comment("Graham", "I love visiting here often"));
        video2.StoreComment(new Comment("Bob", "Great location for work"));
        video2.StoreComment(new Comment("Perry", "Most of my family lives here."));
        video3.StoreComment(new Comment("John", "Thank you for the study tips!"));
        video3.StoreComment(new Comment("Tim", "Your awesome"));
        video3.StoreComment(new Comment("James", "I never thought of it like this."));

        Console.WriteLine("Youtube Video Program");
        foreach (Video video in videos)
        {
            video.DisplayVideoInformation();
        }
    }
}