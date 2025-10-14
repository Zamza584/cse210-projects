public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (isComplete())
        {
            return _bonus;
        }
        return _points;
    }
    public override bool isComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }
    public override string GetDetailsString()
    {
        if (isComplete() == true)
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRespresentation()
    {
        return $"Name: {_shortName} Description: {_description} Points: {_points}";
    }
}