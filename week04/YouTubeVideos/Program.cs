using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Mini Lego Project", "Grace20103", 420);
        Video video2 = new Video("Modding my Car in NBA2k!!", "Ronnie2k", 600);
        Video video3 = new Video("Beating the Enderdragon", "Pewdiepie", 1050);

        video1.AddComment(new Comment("LegoGuy123", "Very Creative!"));
        video1.AddComment(new Comment("Bob", "Nice!!!"));
        video1.AddComment(new Comment("SelenaWorks2019", "I want to do this so bad"));

        video2.AddComment(new Comment("BasketballDave", "Nice try Ronnie. Fix the game"));
        video2.AddComment(new Comment("Larry2k", "Cool Mods!"));
        video2.AddComment(new Comment("2kLegendFrench", "Green Machine Car"));

        video3.AddComment(new Comment("user9028523", "I've been waiting for this moment my whole life."));
        video3.AddComment(new Comment("TheMCBoy", "The finish line. Congrats"));
        video3.AddComment(new Comment("Leonard", "Finally!!!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length/60f} minutes");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}