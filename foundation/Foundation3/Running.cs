public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int durationInMinutes, double distance) 
        : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / (double)DurationInMinutes) * 60; // mph

    public override double GetPace() => (double)DurationInMinutes / _distance; // min per mile
}