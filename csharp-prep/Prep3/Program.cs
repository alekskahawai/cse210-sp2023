using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess a magic number!");

        /* 01 Core
        Start by asking the user for the magic number.
        Ask the user for a guess.
        Using an if statement, determine 
        if the user needs to guess higher or lower next time, or tell them if they guessed it. */

        // // Input
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Console.Write("What is your guess? ");
        // int guess = int.Parse(Console.ReadLine());

        // // Logic and Output
        // if (guess == magicNumber)
        // {
        //     Console.WriteLine("You guessed it!");
        // }    
        // else if (guess < magicNumber)
        // {
        //     Console.WriteLine("Higher!");
        // }
        // else
        // {
        //     Console.WriteLine("Lower!");
        // }

        /* 02 Core
        Add a loop that keeps looping as long as the guess does not match the magic number.
        At this point, the user should be able to keep playing until they get the correct answer. */

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // int guess = 0;

        // while (guess != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());

        //     // Logic and Output
        //     if (guess == magicNumber)
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }    
        //     else if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Higher!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Lower!");
        //     }
        // }

        /* 03 Core
        Instead of having the user supply the magic number, generate a random number from 1 to 100. */
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 101);

        // int guess = 0;

        // while (guess != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());

        //     // Logic and Output
        //     if (guess == magicNumber)
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }    
        //     else if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Higher!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Lower!");
        //     }
        // }

        /* 01 Stretch
        Keep track of how many guesses the user has made and inform them of it at the end of the game. */
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 101);
        // //Console.WriteLine(magicNumber);

        // int guess = 0;
        // int attempts = 0;

        // while (guess != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());
        //     attempts++;

        //     // Logic and Output
        //     if (guess == magicNumber)
        //     {
        //         Console.WriteLine($"You guessed it in {attempts} attempts");
        //     }    
        //     else if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Higher!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Lower!");
        //     }
        // }

        /* 02 Stretch
        After the game is over, ask the user if they want to play again. 
        Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes". */
        string response;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            //Console.WriteLine(magicNumber);

            int guess = 0;
            int attempts = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                // Logic and Output
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts");
                }    
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Lower!");
                }
            } 

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("Thank you for the game.");
    }
}