// Derived class for Swimming activity
public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int durationMinutes, int laps)
    {
        Date = date;
        DurationMinutes = durationMinutes;
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (Laps * 50 / 1000.0) / (DurationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return (DurationMinutes / 60.0) / (Laps * 50 / 1000.0);
    }
}