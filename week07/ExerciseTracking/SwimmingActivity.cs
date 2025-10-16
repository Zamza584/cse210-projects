public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return (float)_laps * 50 / 1000 * 0.62;
    }
    public override double CalculateSpeed()
    {
        return (float)CalculateDistance() / (float)_length * 60;
    }
    public override double CalculatePace()
    {
        return (float)_length / (float)CalculateDistance();
    }
    public override string GetFullSummary()
    {
        return $"{_date} Swimming ({_length} min) - Distance {CalculateDistance().ToString("F2")} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph, Pace {CalculatePace().ToString("F2")} min per mile";
    }

}