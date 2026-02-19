public class Swimming : Activity
{
    private int _laps;
    private const double LapDistanceMiles = 50 / 1000.0 * 0.62; // meters to miles

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapDistanceMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
