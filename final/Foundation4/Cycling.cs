// Derived class for Cycling activity
public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int durationMinutes, double speed)
    {
        Date = date;
        DurationMinutes = durationMinutes;
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * (DurationMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}