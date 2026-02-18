public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -_points;
    }

    public override string GetStatus()
    {
        return $"[!] {GetName()} (Penalty Goal)";
    }
    public override string GetSaveString()
    {
        return $"{GetType().Name}|{GetName()}|{_points}";
    }

}
