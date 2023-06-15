/* Prompt the user for their first name. Then, prompt them for their last name. Display the text back all on one line saying, "Your name is last-name, first-name, last-name" as shown: */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        /* Prompt the user for their first name. What is your first name? */
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        /* prompt them for their last name. What is your last name? */
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        /* Display the text back all on one line saying, 
        "Your name is last-name, first-name, last-name" as shown:  
        Your name is Young, Brigham Young.
        */
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}