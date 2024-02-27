// Derived class for Running activity
public class Running : Activity
{
    public double _distance { get; set; }

    public Running(DateTime date, int durationMinutes, double distance)
    {
        _Date = date;
        _DurationMinutes = durationMinutes;
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return _DurationMinutes / _distance;
    }
}
