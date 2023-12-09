using System;

public class Biking : Activity
{
    private double _speed;

    public Biking(string type, string date, double length, double speed) : base(type, date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _length / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}