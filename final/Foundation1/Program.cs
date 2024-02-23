using System;

class Program
{
    static void Main()
    {
        List<Video> _videoList = new List<Video>()
    {
        new Video("F1 LIVE: 2024 Post Test Reaction", "Formula 1", 2520),
        new Video("Jaylen Brown's Dunk Over Kai Cenat Wins The NBA All-Star", "NBA on TNT", 180),
        new Video("LA TRIBU TOLTECA | Martín El Constructor", "Soy Tribu", 1879),
        new Video("¿Qué pasó de verdad durante los Juicios de las Brujas de Salem?", "TED-Ed Español", 326)
    };

    foreach (var video in _videoList)
    {
        video.AddComment(new Comment("@chicken", "Merc fighting for P4-P5 Constructors"));
        video.AddComment(new Comment("@topfactbb", "Max is such a chill champ"));
        video.AddComment(new Comment("@orio_3", "Great interview"));
    }

    foreach (var video in _videoList)
    {
        Console.WriteLine($"Title: {video._title}");
        Console.WriteLine($"Author: {video._author}");
        Console.WriteLine($"Duration: {video._duration}");
        Console.WriteLine($"Number of comments posted: {video.GetCommentsNumber()}");
        Console.WriteLine($"Comments: ");
        foreach (var comment in video._comments)
        {
            Console.WriteLine($"{comment._name}: {comment._commentText}");
        }
        Console.WriteLine();
    }
}
}