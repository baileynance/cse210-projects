using System;

public class ChecklistGoal : Goal
{
    private int _quantity;
    private int _bonus;

    private int _completion;

    public ChecklistGoal(string goal, string description, int points, int quantity, int bonus, int completion = 0, int totalPoints = 0) : base(goal, description, points)
    {
        _quantity = quantity;
        _bonus = bonus;
        _completion = completion;
        _goalType = "checklist";
        _totalPoints = totalPoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_listGoal} -- Currently Completed {_completion}/{_quantity}");
    }

    public override string CompleteGoal()
    {
        _completion++;
        if (_completion == _quantity)
        {
            return $"[X] {_goal} ({_description})";
        }
        else return $"[ ] {_goal} ({_description})";
    }

    public override int AddPoints()
    {
        if (_completion == _quantity)
        {
            return _points + _bonus;
        }
        else return _points;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType},{_goal},{_description},{_points},{_quantity},{_bonus},{_completion},{_totalPoints}";
    }
}