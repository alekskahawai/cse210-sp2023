public class Swimming : Activity
{
    // Attributes:
    private float _laps;   // length of a lap in the lap pool is 50 meters

    // constructor
    public Swimming(string date, string activityType, int length, float laps) : base(date, activityType, length)
    {
        _laps = laps;
    }

    // Behaviors:
    // *  GetDistance( )  :  float   // km
public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    // *  GetPace( )  :  float   // min/km
    // Pace = Time / Distance  
    // Source: https://www.buxtonwater.co.uk/articles/marathon-and-training/calculate-your-running-pace#:~:text=Pace%20%3D%20Time%20%2F%20Distance,a%20round%20number%20of%20minutes.
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}