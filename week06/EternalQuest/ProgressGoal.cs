public class ProgressGoal : Goal
{
    private int _targetAmount;
    private int _currentAmount;

    public ProgressGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        _targetAmount = target;
        _currentAmount = 0;
    }

    public override int RecordEvent()
    {
        Console.Write("Enter amount of progress: ");
        int amount = int.Parse(Console.ReadLine());

        _currentAmount += amount;

        if (_currentAmount >= _targetAmount)
        {
            _isComplete = true;
        }

        return _points * amount;
    }

    public override string GetStatus()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {GetName()} Progress {_currentAmount}/{_targetAmount}";
    }
    public override string GetSaveString()
    {
        return $"{GetType().Name}|{GetName()}|{_points}|{_targetAmount}|{_currentAmount}|{_isComplete}";
    }

}
