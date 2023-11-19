using System;

public class Goal
{
    protected int _totalPoints;
    protected string _goalType;
    protected string _goal;
    protected string _description;
    protected int _points;
    protected string _listGoal;

    public Goal(string goal, string description, int points)
    {
        _goal = goal;
        _description = description;
        _points = points;
        _listGoal = $"[ ] {_goal} ({_description})";
        _totalPoints = 0;
    }

    public void RecordEvent()
    {
        _listGoal = CompleteGoal();
        _points = AddPoints();
    }

    // Base methods to override in other classes

    public virtual void DisplayGoal()
    {
        Console.WriteLine(_listGoal);
    }

    public virtual string CompleteGoal()
    {
        return $"[X] {_goal} ({_description})";
    }

    public virtual int AddPoints()
    {
        _totalPoints += _points;
        return _points;
    }

    // Get methods to inherit and use attributes in other classes 

    public string GetGoalName()
    {
        return _goal;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetListGoal()
    {
        return _listGoal;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    // Saving goal as string for file sharing

    public virtual string GetStringRepresentation()
    {
        return $"{_goalType},{_goal},{_description},{_points},{_totalPoints}";
    }
}