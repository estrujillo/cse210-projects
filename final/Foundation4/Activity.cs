using System;

// Base Activity class
public abstract class Activity
{
    protected DateTime _Date { get; set; }
    protected int _DurationMinutes { get; set; }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to generate summary information
    public virtual string GetSummary()
    {
        return $"{_Date.ToString("dd MMM yyyy")} - {GetType().Name} ({_DurationMinutes} min): " + $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}