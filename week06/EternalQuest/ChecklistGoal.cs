public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetStatus()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {GetName()} Completed {_amountCompleted}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"{GetType().Name}|{GetName()}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
