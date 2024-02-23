using System;

class Program
{
    static void Main()
    {
        // Creating events
        Lectures lectureEvent = new Lectures("Lecture Title", "Description of the lecture", new DateTime(2024, 2, 14), new TimeSpan(9, 0, 0), "123 Main St", "Anytown", "CA", "USA", "John Doe", 50);

        Receptions receptionEvent = new Receptions("Reception Title", "Description of the reception", new DateTime(2024, 3, 20), new TimeSpan(18, 0, 0), "456 Oak St", "Other City", "NY", "USA", "example@example.com");

        OutdoorGatherings outdoorEvent = new OutdoorGatherings("Outdoor Gathering Title", "Description of the outdoor gathering", new DateTime(2024, 4, 15), new TimeSpan(15, 0, 0), "789 Elm St", "Small Town", "TX", "USA", "Sunny");

        // Display event details
        DisplayEventDetails(lectureEvent);
        Console.WriteLine();
        DisplayEventDetails(receptionEvent);
        Console.WriteLine();
        DisplayEventDetails(outdoorEvent);
    }
    static void DisplayEventDetails(Event ev)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(ev.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(ev.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(ev.GetShortDescription());
        Console.WriteLine();
    }
}