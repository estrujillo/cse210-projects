using System;

public class Video
{
    public string _title {get; set;}
    public string _author {get; set;}
    public int _duration {get; set;}
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentsNumber()
    {
        return _comments.Count;
    }
}