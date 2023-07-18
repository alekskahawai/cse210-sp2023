public class Address
{
    // Attributes: 
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _postalCode;

    // constructor
    public Address(string streetAddress, string city, string state, string postalCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _postalCode = postalCode;
    }

    // Address address = new Address();

    // Behaviors:
    // *  GetFullAddress( )  :  string
    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_postalCode}";
    }
}

