using System;

public class Video
{
    private string _title;
    private string _author;
    private double _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public double GetLength()
    {
        return _length;
    }

    public int GetAmount()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"({comment.GetName()}) - {comment.GetText()}");
        }
    }
}