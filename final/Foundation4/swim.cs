public class Swimming : Activity
{
    // Attributes:
    private int _laps;   // length of a lap in the lap pool is 50 meters

    // Behaviors:
    // *  GetDistance( )  :  float   // km
public override float GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public override float GetSpeed()
    {
        return 0;
    }

    // *  GetPace( )  :  float   // min/km
    public override float GetPace()
    {
        return 0;
    }
}