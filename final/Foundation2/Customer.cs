public class Customer
{
    // Attributes:
    private string _customerName;
    private Address _customerAddress;

    // constructor

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
}