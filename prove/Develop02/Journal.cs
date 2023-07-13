using System;
using System.IO;

// Stores a list of journal entries.
public class Journal
{
    // Create the member variable for the list of Entries.
    public List<Entry> _entries = new List<Entry>();

    // Adding an entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry); 
        
        // theJournal.AddEntry(anEntry) when you want to add a new entry to the journal
    }

    // Displaying all the entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saving to a file
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}^{entry._promptText}^{entry._entryText}^{entry._scriptures}");
            }
        }
    }

    // Loading from a file. This should replace any entries currently stored the journal.
    public void LoadFromFile(string fileName)
    {
        // Clear all current entries.
        _entries.Clear();

        // read the file and store in dynamic array
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("^");

            // indaxes:
            // parts[0] - date
            // parts[1] - prompt
            // parts[2] - entryText
            // parts[3] - scriptures

            // creat an Entry instance
            Entry anEntry = new Entry(parts[0], parts[1], parts[2], parts[3]);

            _entries.Add(anEntry);
        }
    }
}