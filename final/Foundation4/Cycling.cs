public class Cycling : Activity
{
    // Attributes:
    private float _speed;

    // Behaviors:
    // *  GetDistance( )  :  float   // km
public override float GetDistance()
    {
        return 0;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public override float GetSpeed()
    {
        return _speed;
    }

    // *  GetPace( )  :  float   // min/km
    public override float GetPace()
    {
        return 0;
    }
}
