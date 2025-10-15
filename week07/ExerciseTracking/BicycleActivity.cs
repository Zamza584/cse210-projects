public class BicycleActivity : Activity
{
    private float _speed;

    public BicycleActivity(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return _speed * _length;
    }
    public override float CalculateSpeed()
    {
        return CalculateDistance() / _length;
    }
    public override float CalculatePace()
    {
        return CalculateDistance() / (_length / 60);
    }
    public override string GetFullSummary()
    {
        return "";
    }

}