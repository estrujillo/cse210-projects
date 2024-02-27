// Derived class for Swimming activity
public class Swimming : Activity
{
    public int _laps { get; set; }

    public Swimming(DateTime date, int durationMinutes, int laps)
    {
        _Date = date;
        _DurationMinutes = durationMinutes;
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (_laps * 50 / 1000.0) / (_DurationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return (_DurationMinutes / 60.0) / (_laps * 50 / 1000.0);
    }
}