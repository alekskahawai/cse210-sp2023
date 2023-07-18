using System;

class Program
{
    static void Main(string[] args)
    {
        // create a LECTURE event
        Address lectureAddress = new Address("1 Albert Square", "London", "England", "United Kingdom");

        Lecture lecture = new Lecture("Lecture", "The Royal Ballet", "Augue mauris augue neque gravida in fermentum et sollicitudin acumus ispom dur.", "10 Aug 2023", "12.30 PM", "James C. Karentum", "300", lectureAddress);
        
        // Display messages
        Console.WriteLine("\nLECTURE");
        Console.WriteLine($"Standard Details \n{lecture.GetStandardDetails()}");
        Console.WriteLine($"\nFull Details \n{lecture.GetFullDetails()}");
        Console.WriteLine($"\nShort Details \n{lecture.GetShortDetails()}");

        // create a RECEPTION event
        Address receptionAddress = new Address("101 Market Street", "New York", "NY", "USA");

        Reception reception = new Reception("Reception", "Gala Evening", "Special guest reception latinum orbe unom, galika orto stumbura otto magnifica.", "21 Aug 2023", "6.30 PM", "registration@email.com", receptionAddress);
        
        // Display messages
        Console.WriteLine("\nRECEPTION");
        Console.WriteLine($"Standard Details \n{reception.GetStandardDetails()}");
        Console.WriteLine($"\nFull Details \n{reception.GetFullDetails()}");
        Console.WriteLine($"\nShort Details \n{reception.GetShortDetails()}");

        // create a OUTDOOR gathering event
        Address outdoorAddress = new Address("Costa Brava", "Barcelona", "Catalona", "Spain");

        Outdoor outdoor = new Outdoor("Outdoor gathering", "Beach Volleyball EURO23", "Id neque aliquam vestibulum morbi blandit cursus risus at ultrices.", "31 Aug 2023", "10.30 AM", "Sunny +30C", outdoorAddress);
        
        // Display messages
        Console.WriteLine("\nOUTDOOR");
        Console.WriteLine($"Standard Details \n{outdoor.GetStandardDetails()}");
        Console.WriteLine($"\nFull Details \n{outdoor.GetFullDetails()}");
        Console.WriteLine($"\nShort Details \n{outdoor.GetShortDetails()}");
    }
}