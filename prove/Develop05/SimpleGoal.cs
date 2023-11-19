using System;

public class SimpleGoal : Goal
{   
    public SimpleGoal(string goal, string description, int points, int totalPoints = 0) : base(goal, description, points)
    {
        _goalType = "simple";
        _totalPoints = totalPoints;
    }

    public override string CompleteGoal()
    {
        return $"[X] {_goal} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType},{_goal},{_description},{_points},{_totalPoints}";
    }

    public bool IsCompleted()
    {
        if (_totalPoints > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void DisplayGoal()
    {
        if (IsCompleted())
        {
            Console.WriteLine($"[X] {_goal} ({_description})");
        }
        else
        {
            Console.WriteLine(_listGoal);
        }
    }
}