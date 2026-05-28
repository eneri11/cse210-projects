using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Transactions;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set;}
    public int LengthSeconds { get; set;}

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
    }

    // Add a comment (encapsulated behavior)
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //Return number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Get all comments (for display purposes)
    public List<Comment> GetComments()
    {
        return _comments;
    }
}