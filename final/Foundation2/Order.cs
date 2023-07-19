public class Order
{
    // Attributes:
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    // constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Behaviors:
    // *  AddProduct(newProduct  :  Product)  :  void
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);   
    }

    // *  TotalCost( )  :  double
    // USA shipping $5, non-USA $35.
    public double TotalCost()  // orderSubTotal + shipping
    {
        // double totalCost = 0;
        double orderSubTotal = 0;
        foreach (Product product in _products)
        {
            orderSubTotal += product.ProductSubTotal();
        }

        int shipping = 0;
        if (_customer.InUSA())
            shipping = 5;
        else
            shipping = 35;

        double totalCost = orderSubTotal + shipping;

        return totalCost;
    }

    // *  ShippingLabel( )  :  string
    // list the name and address of the customer
    public string ShippingLabel()
    {
        return $"Name: {_customer.GetCustomerName()} \nAddress: \n{_customer.GetCustomerAddress()}";
    }

    // *  PackingLabel( )  :  string
    // list the name and product id of each product in the order.
    public string PackingLabel() 
    {
        string packingString = "";
        foreach (Product product in _products) 
        {
            packingString += product.GetProductName() + "\t" + product.GetProductId() + "\n";
        }

        return packingString;
    }
}

