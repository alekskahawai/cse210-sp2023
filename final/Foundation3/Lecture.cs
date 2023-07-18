public class Lecture : Event
{
    // Attributes:
    private string _speaker;
    private string _capacity;

    // constructor
    public Lecture(string type, string title, string description, string date, string time, string speaker, string capacity, Address address) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Behaviors:
    // *  GetFullDetails( )  :  string // standard details + type, _speaker, _capacity
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nType: {GetEventType()} \nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
