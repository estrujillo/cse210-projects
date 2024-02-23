using System;

public class Comment
{
    public string _name {get; set;}
    public string _commentText {get; set;}

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

}