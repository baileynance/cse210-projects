using System;
using System.Diagnostics.Tracing;

public class Activity
{
    protected string _type;
    protected string _date;
    protected double _length;

    public Activity(string type, string date, double length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min) - Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
}