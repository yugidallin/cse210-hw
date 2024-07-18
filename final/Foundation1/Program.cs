using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Video objects
        Video video1 = new Video("C# Tutorial", "CodeMaster", 600);
        Video video2 = new Video("Cooking Basics", "ChefExtraordinaire", 900);
        Video video3 = new Video("Guitar Lessons", "RockStar101", 1200);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you explain more about classes?"));

        video2.AddComment(new Comment("David", "Loved the recipe!"));
        video2.AddComment(new Comment("Eve", "What's a good substitute for butter?"));
        video2.AddComment(new Comment("Frank", "Your instructions are so clear!"));

        video3.AddComment(new Comment("Grace", "This helped me improve my technique."));
        video3.AddComment(new Comment("Henry", "Can you do a video on finger picking?"));
        video3.AddComment(new Comment("Ivy", "You're an amazing teacher!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}