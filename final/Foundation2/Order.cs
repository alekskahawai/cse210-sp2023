public class Order
{
    // Attributes:
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    // constructor

    // Behaviors:
    // *  AddProduct(newProduct  :  Product)  :  void
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);   
    }

    // *  TotalCost( )  :  float
    public float TotalCost()
    {
        return 45;
    }

    // *  ShippingLabel( )  :  string
    public string ShippingLabel()
    {
        return "";
    }

    // *  PackingLabel( )  :  string
    public string PackingLabel()
    {
        return "";
    }
}

