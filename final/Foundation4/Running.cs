public class Running : Activity
{
    // Attributes:
    private double _distance;

    // constructor
    public Running(string date, string activityType, int length, double distance) : base(date, activityType, length)
    {
        _distance = distance;
    }

    // Behaviors:
    // *  GetDistance( )  :  float   // km
    public override double GetDistance()
    {
        return _distance;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    // *  GetPace( )  :  float   // min/km
    // Pace = Time / Distance  
    // Source: https://www.buxtonwater.co.uk/articles/marathon-and-training/calculate-your-running-pace#:~:text=Pace%20%3D%20Time%20%2F%20Distance,a%20round%20number%20of%20minutes.
    public override double GetPace()
    {
        return GetLength() / _distance;
    }

}