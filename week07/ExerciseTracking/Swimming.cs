using System;

public class Swimming : Activity
{
    // Private member variable unique to Swimming
    private int _numberOfLaps;

    // Constant: each lap in pool is 50 meters
    private const double LapLengthMeters = 50.0;
    private const double MetersPerMile = 1609.34;

    // Constructor
    public Swimming(DateTime date, int lengthInMinutes, int numberOfLaps)
        : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    // Override abstract methods from base class
    public override double GetDistance()
    {
        // Distance (miles) = laps * 50 / 1000 * 0.62
        return _numberOfLaps * LapLengthMeters / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return GetLengthInMinutes() / GetDistance();
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }
}