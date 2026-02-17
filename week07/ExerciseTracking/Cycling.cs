using System;

public class Cycling : Activity
{
    // Private member variable unique to Cycling
    private double _speed; // mph - this IS stored for cycling

    // Constructor
    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    // Override abstract methods from base class
    public override double GetDistance()
    {
        // Distance = (speed / 60) * minutes
        return (_speed / 60) * GetLengthInMinutes();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = 60 / speed
        return 60 / _speed;
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }
}