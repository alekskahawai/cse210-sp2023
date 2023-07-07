using System;

// Create a class to hold fraction.
class Fraction
{
    /* The class should have two attributes for the top and bottom numbers. 
    Make sure the attributes are private. */
    private int _topNumber;
    private int _bottomNumber;

    // Create the following constructors:
    // Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;            
    }

    // Create getters and setters for both the top and the bottom values.
    public int GetTopNumber()
    {
        return _topNumber;
    }

    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    // Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        string fractionString = $"{_topNumber}/{_bottomNumber}";
        return fractionString;
    }

    // Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        double decimalValue = (double)_topNumber / (double)_bottomNumber;
        return decimalValue;
    }
}