public class Activity
{
    // Attributes:
    private string _date; // 03 Nov 2022
    private string _activityType;
    private int _length; // length of the activity in minutes

    // constructor
    public Activity(string date, string activityType, int length)
    {
        _date = date;
        _activityType = activityType;
        _length = length;
    }

    // Behaviors:
    // *  GetSummary( )  :  string
    // Sample Summary: 
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_length} min)- Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }

    // *  GetLength( )  :  int           // min
    public int GetLength()
    {
        return _length;
    }

    // *  GetDistance( )  :  float   // km
    public virtual double GetDistance()
    {
        return 0;
    }

    // *  GetSpeed( )  :  float    // km/hr
    public virtual double GetSpeed()
    {
        return 0;
    }

    // *  GetPace( )  :  float   // min/km
    public virtual double GetPace()
    {
        return 0;
    }
}
