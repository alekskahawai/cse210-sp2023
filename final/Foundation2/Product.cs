public class Product
{
    // Attributes:
    private string _productName;
    private string _id;
    private float _price;
    private int _quantity;

    // constructor

    // Behaviors:
    // *  SubTotal( )  :  float
    public float SubTotal()
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
