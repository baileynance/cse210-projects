using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string type, string date, double length, double laps) : base(type, date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}