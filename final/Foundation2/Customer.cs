public class Customer
{
    // Attributes:
    private string _customerName;
    private Address _customerAddress;

    // constructor
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    // Behaviors:
    // * InUSA( )  :  bool
    public bool InUSA()
    {
        return _customerAddress.GetIsUSA();        
    }

    // *  GetCustomerName( )  :  string
    public string GetCustomerName()
    {
        return _customerName;
    }

    // *  GetCustomerName( )  :  string
    public string GetCustomerAddress()
    {
        return _customerAddress.GetFullAddress();
    }
}