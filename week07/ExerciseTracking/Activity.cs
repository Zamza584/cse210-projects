public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract float CalculateDistance();
    public abstract float CalculateSpeed();
    public abstract float CalculatePace();
    public abstract string GetFullSummary();

}