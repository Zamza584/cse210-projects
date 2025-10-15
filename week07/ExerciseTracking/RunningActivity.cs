public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float CalculateDistance()
    {
        return 0;
    }

    public override float CalculateSpeed()
    {
        return 0;
    }
    public override float CalculatePace()
    {
        return 0;
    }
    public override string GetFullSummary()
    {
        return "";
    }

}