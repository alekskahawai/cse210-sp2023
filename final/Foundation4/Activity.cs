public class Activity
{
    // Attributes:
    private string _date; 
    private int _length; // length of the activity in minutes

    // Behaviors:
    // *  GetLength( )  :  int           // min
    public int GetLength()
    {
        return _length;
    }

    // *  GetDistance( )  :  float   // km
    public virtual float GetDistance()
    {
        return 0;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public virtual float GetSpeed()
    {
        return 0;
    }

    // *  GetPace( )  :  float   // min/km
    public virtual float GetPace()
    {
        return 0;
    }

    // *  GetSummary( )  :  string
    // Sample Summary: 
    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    public string GetSummary()
    {
        return $"";
    }

}
