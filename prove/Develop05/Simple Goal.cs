public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return int.Parse(_points);
        }
        return 0;
    }

    public override bool IsCompleted() => _isComplete;

    public override string GetDetailsString() => $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";

    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}