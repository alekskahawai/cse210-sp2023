public class Event
{
    // Attributes:
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address; /*  = new Address(); */

    // constructor
    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Behaviors:
    // *  GetStandardDetails( )  :  string // title, description, date, time, and address
    public string GetStandardDetails()
    {
        return $"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.GetFullAddress()}";
    }

    // *  GetShortDetails( )  :  string // type, title, date
    public string GetShortDetails()
    {
        return $"Type: {_type} \nTitle: {_title} \nDate: {_date}";
    }

    // *  GetEvenType( )  :  string // type
    public string GetEventType()
    {
        return _type;
    }

}