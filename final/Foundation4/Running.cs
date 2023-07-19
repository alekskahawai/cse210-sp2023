public class Running : Activity
{
    // Attributes:
    private float _distance;

    // Behaviors:
    // *  GetDistance( )  :  float   // km
    public override float GetDistance()
    {
        return _distance;
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