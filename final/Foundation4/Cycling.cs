// Derived class for Cycling activity
public class Cycling : Activity
{
    public double _speed { get; set; }

    public Cycling(DateTime date, int durationMinutes, double speed)
    {
        _Date = date;
        _DurationMinutes = durationMinutes;
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_DurationMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}