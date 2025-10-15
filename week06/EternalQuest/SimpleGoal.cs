public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool isComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRespresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}