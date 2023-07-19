public class Cycling : Activity
{
    // Attributes:
    private double _speed; // kph
 
    // constructor
    public Cycling(string date, string activityType, int length, double speed) : base(date, activityType, length)
    {
        _speed = speed;
    }

    // Behaviors:
    // *  GetDistance( )  :  float   // km
    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public override double GetSpeed()
    {
        return _speed;
    }

    // *  GetPace( )  :  float   // min/km
    // Pace = Time / Distance  
    // Source: https://www.buxtonwater.co.uk/articles/marathon-and-training/calculate-your-running-pace#:~:text=Pace%20%3D%20Time%20%2F%20Distance,a%20round%20number%20of%20minutes.
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
