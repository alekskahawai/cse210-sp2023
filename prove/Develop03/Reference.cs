// Keeps track of the book, chapter, and verse information.
public class Reference
{
    // Attributes:
    /* The Reference class will need to store a variable for the book (string), the chapter (int), and the verse (int). Then, it will also need to store one additional variable for second, or "end," verse of the range to handle the case of Proverbs 3:5-6. */
    private string _book;
    private int _chapter, _verse, _endVerse;

    // constructor
    // This ability to have multiple versions of a function, as long as the parameters are different is called 'Function Overloading', and it is possible with any function not just constructors.
    public Reference(string book, int chapter,int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter,int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Behaviors:
    // GetDisplayText() : string
    // John 3:16  &  Proverbs 3:5-6
    public string GetDisplayText()
    {
        if (_endVerse > 0)
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        else
            return $"{_book} {_chapter}:{_verse}";
    }
}