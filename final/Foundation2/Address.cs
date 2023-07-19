public class Address
{
    // Attributes:  
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Behaviors:
    // *  IsUSA( )  :  bool
    public bool GetIsUSA()
    {
        if (_country.ToLower() == "usa")
            return true;
        else
            return false;        
    }

    // *  GetFullAddress( )  :  string
    public string GetFullAddress()
    {
        return $"{_streetAddress} \n{_city} \n{_state} \n{_country}";
    }
}