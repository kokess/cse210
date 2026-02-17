using System;

public class Running : Activity
{
    // Private member variable unique to Running
    private double _distance; // in miles

    // Constructor
    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    // Override abstract methods from base class
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (_distance / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return GetLengthInMinutes() / _distance;
    }

    public override string GetActivityType()
    {
        return "Running";
    }
}