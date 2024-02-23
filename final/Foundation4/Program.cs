using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        var running = new Running(new DateTime(2024, 02, 22), 30, 4.8);
        var cycling = new Cycling(new DateTime(2024, 02, 22), 30, 15);
        var swimming = new Swimming(new DateTime(2024, 02, 22), 30, 10);

        // Display summaries
        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}