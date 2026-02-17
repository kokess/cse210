using System;

public abstract class Activity
{
    // Private member variables (encapsulation)
    private DateTime _date;
    private int _lengthInMinutes;

    // Constructor
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Getters for private fields
    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    // Abstract methods (declared but not implemented - overridden in derived classes)
    public abstract double GetDistance();   // in miles
    public abstract double GetSpeed();      // mph
    public abstract double GetPace();       // min per mile
    public abstract string GetActivityType();

    // GetSummary uses virtual methods - defined once in base class
    public string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy");
        string activityType = GetActivityType();
        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);

        return $"{dateStr} {activityType} ({_lengthInMinutes} min)- " +
               $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}