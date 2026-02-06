using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Learning C#", "Code Academy", 600);
        Video video2 = new Video("OOP Principles Explained", "Tech World", 850);
        Video video3 = new Video("Abstraction in Programming", "BYU-I", 720);

        video1.AddComment(new Comment("Alice", "This video was very helpful!"));
        video1.AddComment(new Comment("James", "Clear explanation, thanks."));
        video1.AddComment(new Comment("Maria", "Loved the examples."));

        video2.AddComment(new Comment("John", "OOP finally makes sense."));
        video2.AddComment(new Comment("Sarah", "Great breakdown of concepts."));
        video2.AddComment(new Comment("Mike", "Very informative."));

        video3.AddComment(new Comment("Emma", "Perfect for beginners."));
        video3.AddComment(new Comment("Daniel", "This helped my assignment."));
        video3.AddComment(new Comment("Grace", "Well explained abstraction."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}





public class Video
{
    public string Title { get; private set; }

    public string Author { get; private set; }

    public int Length { get; private set; }

    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;

        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}




public class Comment
{
    public string CommenterName { get; private set; }

    public string Text { get; private set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
