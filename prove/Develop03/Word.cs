/* Keeps track of a single word and whether it is shown or hidden.
The key behaviors for the Word class are to hide and show a word and to check if a word is hidden or not. In addition, a Word should have a behavior to get the display text of that word, which would be either the word itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores (for example, "______"). */
public class Word
{
    // Attributes:
    /* The Word class will need to store the text of the word itself (a string) and a variable to indicate whether that word is shown or hidden (a boolean). */
    private string _wordText;
    private bool _isHidden;

    // constructor
    /* This constructor should accept the text of the word to save it as an attribute. In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). Notice that you should not need to pass in the visibility of the word. It can be set to be visible by default. */
    public Word(string wordText, bool isHidden)
    {
        _wordText = wordText;
        _isHidden = isHidden;
    }

    public Word()
    {
        
    }

    // Behaviors:
    // Hide() : void
    public void Hide()
    {
        _isHidden = true;
    }

    // Show() : void
    public void Show()
    {
        _isHidden = false;
    }

    // IsHidden() : bool
    public bool IsHidden()
    {
        return _isHidden;
    }

    // GetDisplayText() : string
    public string GetDisplayText()
    {
        return _wordText;
    }
}