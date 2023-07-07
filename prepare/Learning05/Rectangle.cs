using System;

/* create the Rectangle class.
Make sure this class inherits from the base class. */
public class Rectangle : Shape
{

    // Create a constructor that accepts the color, the length and the width, and then call the base constructor with the color.
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Create _length and _width attributes as a private member variables.
    private double _length;
    private double _width;

    // Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override double GetArea()
    {
        return _length * _width;
    }

}