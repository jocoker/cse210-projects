public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int durationInMinutes, double speed) 
        : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * (double)DurationInMinutes / 60; // miles

    public override double GetSpeed() => _speed; // mph

    public override double GetPace() => 60 / _speed; // min per mile
}