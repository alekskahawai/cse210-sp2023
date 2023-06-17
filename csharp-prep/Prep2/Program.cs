using System;

class Program
{
    /* Grade Calculator */
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");

        /* CORE REQUIREMENTS
        1. 
        Ask the user for their grade percentage, 
        then write a series of if-elif-else statements to 
        print out the appropriate letter grade. 
        (At this point, you'll have a separate print statement 
        for each grade letter in the appropriate block.) */

        // Console.Write("What is your grade percentage? ");
        // string userInput = Console.ReadLine();
        // int gradePercent = int.Parse(userInput);

        // if (gradePercent >= 90)
        // {
        //     Console.WriteLine("Your latter grade is A");
        // }
        // else if (gradePercent >= 80)
        // {
        //     Console.WriteLine("Your latter grade is B");
        // }
        // else if (gradePercent >= 70)
        // {
        //     Console.WriteLine("Your latter grade is C");
        // }
        // else if (gradePercent >= 60)
        // {
        //     Console.WriteLine("Your latter grade is D");
        // }
        // else
        // {
        //     Console.WriteLine("Your latter grade is F");
        // }

        /* 2. 
        Assume that you must have at least a 70 to pass the class. 
        After determining the letter grade and printing it out. 
        Add a separate if statement to determine if the user passed the course, 
        and if so display a message to congratulate them. If not, 
        display a different message to encourage them for next time. */

        // if (gradePercent >= 70)
        // {
        //     Console.WriteLine("Congratulations! You passed the class.");
        // }
        // else
        // {
        //     Console.WriteLine("You can retake the class next semester.");
        // }

        /* 3. 
        Change your code from the first part, so that instead of printing 
        the letter grade in the body of each if, elif, or else block, 
        instead create a new variable called letter and then in each block, 
        set this variable to the appropriate value. 
        Finally, after the whole series of if-elif-else statements, 
        have a single print statement that prints the letter grade once. */

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string letterGrade = "";

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Console.WriteLine($"You letter grade is {letterGrade}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You can retake the class next semester.");
        }

        /* Stretch Challenge
        Add + or - to the letter grade. '+' if last digit is >= 7  ; '-' if last digit is < 3
        don't add '+' to letters 'A' and 'F' & don't add '-' to letter 'F' */

        string sign = "";

        if ((gradePercent % 10) >= 7)
        {
            if (letterGrade == "A" || letterGrade == "F")
            {
                sign = "";
            }   
            else
            {
                sign = "+";
            }
                
        }
        
        else if ((gradePercent % 10) < 3)
        {
            if (letterGrade == "F")
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }    
        else
        {
            sign = "";
        }

        Console.WriteLine($"You letter grade is {letterGrade}{sign}");
    }
}