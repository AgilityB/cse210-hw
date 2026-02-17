using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetName() => _name;

    public abstract int RecordEvent();
    public abstract string GetStatus();

    public virtual string GetSaveString()
    {
        return $"{GetType().Name}|{_name}|{_description}|{_points}|{_isComplete}";
    }

    protected string GetDetails()
    {
        return $"{_name} ({_description})";
    }
}
