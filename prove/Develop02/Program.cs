/* This program must contain the following features:

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

class Program
{
    static void Main(string[] args)
    {
        // reusable instances
        Journal theJournal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();

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
                string promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(promptText);

                // read the users response
                Console.Write(">>>");
                string entryText = Console.ReadLine();

                // creat an Entry instance
                Entry anEntry = new Entry(entryDate, promptText, entryText);

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
                
            }

            // #4
            else if (userChoice == "4")
            {
                // prompt the user and read save-to-file name
                Console.Write("Enter the file name to save the journal entries: ");
                string saveFile = Console.ReadLine();

                // call SaveToFile method
                theJournal.SaveToFile(saveFile);
            }

        }
    }
}