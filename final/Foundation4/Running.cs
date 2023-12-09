using System;

public class Running : Activity
{
    private double _distance;

    public Running(string type, string date, double length, double distance) : base(type, date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}