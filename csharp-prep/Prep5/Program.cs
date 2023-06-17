/* 
Sample output of the program could look as follows:

Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Brother Burton, the square of your number is 1764
*/
 using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);        
    }

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }
    
    
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int userNumber)
    {
        int squareNumber = userNumber * userNumber;

        return squareNumber;
    }
    
    
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}