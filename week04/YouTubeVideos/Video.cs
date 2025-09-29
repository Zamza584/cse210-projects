using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void StoreComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int NumberOfComments()
    {
        return comments.Count();
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"--- Video Information ---");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in Seconds: {_lengthInSeconds}");
        Console.WriteLine("--- Comments ---");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"Author: {comment.GetAuthor()}");
            Console.WriteLine($"Comment: {comment.GetTextComment()}");
        }

    }

}