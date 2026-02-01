using System;
using System.Collections.Generic;

public class Video
{
    //Properties
    private string _title;
    private string _author;
    private int _length;

    //list of comments
    private List<Comment> _comments;

    // constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    //Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }


    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }


    // Method to display all comments
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetDisplayText()}");
        }

        Console.WriteLine();
    }
}
