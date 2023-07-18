public class Outdoor : Event
{
    // Attributes:
    private string _weather;

    // constructor
    public Outdoor(string type, string title, string description, string date, string time, string weather, Address address) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }
    
    // Behaviors:
    // *  GetFullDetails( )  :  string  // standard details + type, _weather
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nType: {GetEventType()} \nWeather: {_weather}";
    }
}
