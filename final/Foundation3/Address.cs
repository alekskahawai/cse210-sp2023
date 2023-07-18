public class Address
{
    // Attributes: 
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // constructor // Address address = new Address();
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Behaviors:
    // *  GetFullAddress( )  :  string
    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}

