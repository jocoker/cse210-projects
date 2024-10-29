public abstract class Activity
{
    private DateTime _date;
    private int _durationInMinutes;

    protected Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
        
    }

    protected int DurationInMinutes => _durationInMinutes;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_durationInMinutes} min) - " +
               $"Distance {GetDistance():F1}, Speed {GetSpeed():F1}, Pace: {GetPace():F1} min per unit";
    }
}
