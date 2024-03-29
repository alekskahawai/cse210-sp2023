/* Submission comment.
Creativity: Save other information in the journal entry.

Sometimes people forget to read the Scriptures daily, so while writing a journal there is an additional question for each entry,  "Did you read the Scriptures today?"

// Question about Scriptures
Console.WriteLine("Did you read the Scriptures today?");
Console.Write(">>> ");
string scriptures = Console.ReadLine();

// creat an Entry instance
Entry anEntry = new Entry(entryDate, promptText, entryText, scriptures);
*/

// Week 02 Develop: Journal.  Sources:
// byui-cse.github.io/cse210-ww-course-2023/week02/develop.html
// byui-cse.github.io/cse210-ww-course-2023/week02/design.html
// byui-cse.github.io/cse210-ww-course-2023/week02/prepare.html
/* 
This program must contain the following features:

1. Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.

Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
    Who was the most interesting person I interacted with today?
    What was the best part of my day?
    How did I see the hand of the Lord in my life today?
    What was the strongest emotion I felt today?
    If I had one thing I could do over today, what would it be?
    
2. Display the journal - Iterate through all entries in the journal and display them to the screen.

3. Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.

4. Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal. 

5. Exit
*/
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // reusable instances
        Journal theJournal = new Journal();

        // Display "Welcome to the Journal program!"
        Console.WriteLine("Welcome to the Journal program!");

        // creat collection of programFeatures
        // Source: https://stackoverflow.com/questions/5821163/how-to-split-writeline-over-multiple-lines

        var programFeatures = new[]
        {
            "Please select one of the following options:",
            "1. Write a new entry",
            "2. Display the journal",
            "3. Save the journal to a file",
            "4. Load the journal from a file",
            "5. Exit",
            "What would you like to do? "
        };

        // Display program features until user enters 5 for Exit
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine(); // empty line
            Console.Write(String.Join(Environment.NewLine, programFeatures));

            userChoice = Console.ReadLine(); 

            // #1
            if (userChoice == "1")
            {
                // get current date in format: 12/09/2022
                DateTime theCurrentTime = DateTime.Now;
                string entryDate = theCurrentTime.ToShortDateString();
                // Console.WriteLine(entryDate); // test prints 7/12/2023

                // generate and display a promtp
                PromptGenerator randomPrompt = new PromptGenerator();
                string promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(promptText);

                // read the users response
                Console.Write(">>> ");
                string entryText = Console.ReadLine();

                // Creativity
                // Question about Scriptures
                Console.WriteLine("Did you read the Scriptures today?");
                Console.Write(">>> ");
                string scriptures = Console.ReadLine();

                // creat an Entry instance
                Entry anEntry = new Entry(entryDate, promptText, entryText, scriptures);

                // add new entry to the journal
                theJournal.AddEntry(anEntry);
            }

            // #2
            else if (userChoice == "2")
            {
                // display all journal entries
                theJournal.DisplayAll();
            }

            // #3
            else if (userChoice == "3")
            {
                // prompt the user and read save-to-file name
                Console.Write("Enter the file name to save the journal entries: ");
                
                string saveFile = Console.ReadLine();

                // call SaveToFile method
                theJournal.SaveToFile(saveFile);

                Console.WriteLine("Journal entries saved.");
                // Console.WriteLine(); // empty line
            }

            // #4
            else if (userChoice == "4")
            {
                // ask the user for and read load-from-file name
                Console.Write("Enter name of the file to load the journal from: ");
                
                string loadFile = Console.ReadLine();

                // call LoadFromFile method
                theJournal.LoadFromFile(loadFile);

                Console.WriteLine("Journal entries loaded.");
                // Console.WriteLine(); // empty line
            }
        }
    }
}