using System;

//Class for comment
public class Comment
{
    private string _commenterName;
    private string _commentText;

//Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetDisplayText()
    {
        return $"{_commenterName}: {_commentText}";
    }
}

