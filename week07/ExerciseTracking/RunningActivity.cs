public class RunningActivity : Activity
{
    private float _distance;
    public RunningActivity(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return (float)(_distance / _length) * _length;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }
    public override double CalculatePace()
    {
        return _length / CalculateDistance();
    }
    public override string GetFullSummary()
    {
        return $"{_date} Running ({_length} min) - Distance {CalculateDistance().ToString("F2")} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph, Pace {CalculatePace().ToString("F2")} min per mile";
    }

}