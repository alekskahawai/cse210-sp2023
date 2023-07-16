using System;

// Represents a single journal entry.
public class Entry
{
    // Create the member variables.
    public string _date; // format 12/09/2022
    public string _promptText;
    public string _entryText;
    public string _scriptures;

    // Entry constructor
    public Entry(string date, string promptText, string entryText, string scriptures)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _scriptures = scriptures;
    }

    // has it's own display method. Output sample: 
    // Date: 12/09/2022 - Prompt: How was your day?
    // Entry for the day ...
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"Scriptures: {_scriptures}");
    }
}