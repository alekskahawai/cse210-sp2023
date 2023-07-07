using System;

/* create the Circle class.
Make sure this class inherits from the base class. */
public class Circle : Shape
{

    // Create a constructor that accepts the color and the radius, and then call the base constructor with the color.
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Create the _radius attribute as a private member variable.
    private double _radius;

    // Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}