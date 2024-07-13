public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetShortName() => _shortName;
    public abstract int RecordEvent();
    public abstract bool IsCompleted();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}