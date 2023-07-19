using System;

class Program
{
    static void Main(string[] args)
    {
        // test drive
        // Console.WriteLine();
        // Address testUSA = new Address("10 Morgan Drive", "Boston", "MS", "USA");
        // Console.WriteLine(testUSA.GetIsUSA());
        // Console.WriteLine(testUSA.GetFullAddress());

        // Console.WriteLine();
        // Address testNonUSA = new Address("21 Bolton Road", "Preston", "Lancashire", "UK");
        // Console.WriteLine(testNonUSA.GetIsUSA());
        // Console.WriteLine(testNonUSA.GetFullAddress());

        // create at least two orders with a 2-3 products each
        // Order1 @USA
        Address addressOrder1 = new Address("10 Morgan Drive", "Boston", "MS", "USA");
        
        Customer customer1 = new Customer("Samuel Ferguson", addressOrder1);
        
        Product product1 = new Product("New Gadget", "TRE27634", 10, 2);
        Product product11 = new Product("Office Desk", "DSK34567", 100, 1);
        Product product111 = new Product("Desk Computer", "COM23876", 1000, 2);
        
        Order order1 = new Order(customer1);
        
        order1.AddProduct(product1);
        order1.AddProduct(product11);
        order1.AddProduct(product111);

        // Order2 @non-USA
        Address addressOrder2 = new Address("21 Bolton Road", "Preston", "Lancashire", "UK");
        
        Customer customer2 = new Customer("David Dworek", addressOrder2);
        
        Product product2 = new Product("IKEA Sofa", "SOF63425", 100, 1);
        Product product22 = new Product("Suntung TV", "TVS56723", 1000, 2);
        
        Order order2 = new Order(customer2);
        
        order2.AddProduct(product2);
        order2.AddProduct(product22);

        // Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        // Order1 @USA
        Console.WriteLine();
        Console.WriteLine("Order1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("Order1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine();
        Console.WriteLine($"Order1 Total Cost: ${order1.TotalCost().ToString()}");

        // Order2 @non-USA
        Console.WriteLine();
        Console.WriteLine("Order2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("Order2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine();
        Console.WriteLine($"Order2 Total Cost: ${order2.TotalCost().ToString()}");
    }
}