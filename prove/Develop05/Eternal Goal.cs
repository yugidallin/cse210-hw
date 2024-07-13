public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override int RecordEvent() => int.Parse(_points);

    public override bool IsCompleted() => false;

    public override string GetDetailsString() => $"[ ] {_shortName} ({_description})";

    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}