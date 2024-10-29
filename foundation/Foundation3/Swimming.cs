public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationInMinutes, int laps) 
        : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50 / 1000.0); // in km

    public override double GetSpeed() => (GetDistance() / (double)DurationInMinutes) * 60; // kph

    public override double GetPace() => (double)DurationInMinutes / GetDistance(); // min per km
}