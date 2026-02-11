using System;

public class Circle : Shape
{
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea()
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
