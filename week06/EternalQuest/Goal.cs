public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool isComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        if (isComplete() == true)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }

    }
    public virtual string GetStringRespresentation()
    {
        return "";
    }

    public string GetShortName()
    {
        return _shortName;
    }
}