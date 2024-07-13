public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = int.Parse(_points);
        if (_amountCompleted == _target)
        {
            pointsEarned += _bonus;
        }
        return pointsEarned;
    }

    public override bool IsCompleted() => _amountCompleted >= _target;

    public override string GetDetailsString() => $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
}