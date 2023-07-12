using System;

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

    }
    // Loading from a file
    public void LoadFromFile(string fileName)
    {

    }
}