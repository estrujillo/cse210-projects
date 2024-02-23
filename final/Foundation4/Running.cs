// Derived class for Running activity
public class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, int durationMinutes, double distance)
    {
        Date = date;
        DurationMinutes = durationMinutes;
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / Distance;
    }
}
