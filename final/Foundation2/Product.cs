public class Product
{
    // Attributes:
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string productName, string id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Behaviors:
    // *  SubTotal( )  :  double
    public double ProductSubTotal()
    {
        //float subTotal = _price * _quantity;
        return _price * _quantity;
    }

    // *  GetProductName( )  :  string
    public string GetProductName()
    {
        return _productName;
    }

    // *  GetProductId( )  :  string
    public string GetProductId()
    {
        return _id;
    }
}
