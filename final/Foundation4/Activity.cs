using System;

// Base Activity class
public abstract class Activity
{
    protected DateTime Date { get; set; }
    protected int DurationMinutes { get; set; }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to generate summary information
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} - {GetType().Name} ({DurationMinutes} min): " + $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}