using System;

class Program
{
    static void Main(string[] args)
    {
        Video videos = new List<Video>();

        Video video = new Video("Gaming Highlights", "Gamer123", 300);

        video.AddComment(new Comment("Great video!", "BillyBob3000"));
        video.AddComment(new Comment("That ending was epic!!!", "JaneDoe"));
        video.AddComment(new Comment("You're videos are always so awesome!", "Mr.Kittens2"));
        videos.Add(video);

        video video2 = new Video("Cooking Tips", "ChefMaster", 600);
        video2.AddComment(new Comment("That cracked chicken looks INSANE", "CrackedChickenFan6"));
        video2.AddComment(new Comment("Bro that street corn looked like Nacho Libre status", "HowComeWeCan'tHaveLikeASalad42"));
        videos.Add(video2);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v._title}, Author: {v._author}, Length: {v._lengthInSeconds} seconds");
            v.getComments();
            Console.WriteLine($"Total Comments: {v.getCommentsCount()}");
            Console.WriteLine();
        }
    }
}