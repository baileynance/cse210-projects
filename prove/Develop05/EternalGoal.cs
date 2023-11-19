using System;

public class EternalGoal : Goal
{
    private int _level;
    public EternalGoal(string goal, string description, int points, int totalPoints = 0, int level = 0) : base(goal, description, points)
    {
        _goalType = "eternal";
        _totalPoints = totalPoints;
        _level = level;
    }

    public override string CompleteGoal()
    {
        LevelUp();
        return $"[ ] {_goal} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType},{_goal},{_description},{_points},{_totalPoints},{_level}";
    }

    public void LevelUp()
    {
        _level++;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_listGoal} Level - {_level}");
    }
}