using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        // create a Reception event
        Address address = new Address("101 Market Street", "New York", "New York", "NY 12345");
        Reception reception = new Reception("Reception", "Gala Evening", "Special guest reception latinum orbe unom, galika orto stumbura otto magnifica.", "21 Aug 2023", "6.30 PM", "registration@email.com", address);

        // Display messages
        Console.WriteLine($"\nStandard Details \n{reception.GetStandardDetails()}");
    }
}