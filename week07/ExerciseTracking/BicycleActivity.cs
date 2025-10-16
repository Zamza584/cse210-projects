public class BicycleActivity : Activity
{
    private float _speed;

    public BicycleActivity(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return (float)_speed * _length;
    }
    public override double CalculateSpeed()
    {
        return (float)CalculateDistance() / _length * 60;
    }
    public override double CalculatePace()
    {
        return (float)CalculateDistance() / (_length / 60);
    }
    public override string GetFullSummary()
    {
        return $"{_date} Bicycle ({_length} min) - Distance {CalculateDistance().ToString("F2")} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph, Pace {CalculatePace().ToString("F2")} min per mile";
    }

}