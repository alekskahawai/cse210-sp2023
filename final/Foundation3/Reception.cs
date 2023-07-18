public class Reception : Event
{
    // Attributes:
    // *    :  string
    private string _emailRegistration;

    // constructor
    public Reception(string type, string title, string description, string date, string time, string emailRegistration, Address address) : base(type, title, description, date, time, address)
    {
        _emailRegistration = emailRegistration;
    }

    // Behaviors:
    // *  GetFullDetails( )  :  string // standard details + type, __emailRegistration
}

