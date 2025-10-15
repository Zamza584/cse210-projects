public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float CalculateDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }
    public override float CalculatePace()
    {
        return _length / CalculateDistance();
    }
    public override string GetFullSummary()
    {
        return $"{_date} Swimming ({_length})- Distance{CalculateDistance()} miles, Speed {CalculateSpeed()}, Pace {CalculatePace()} min per mile";
    }

}