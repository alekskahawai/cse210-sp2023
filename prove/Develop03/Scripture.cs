// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    // Attributes:
    /* The Scripture class will need member variables for a reference and list of all of the words in the scripture. The data type for the reference is Reference, the custom class defined above. The data type for the list of words would be List<Word> (notice it is a list of Word objects, rather than a list of strings.) */
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // constructor
    /*Q: What is a benefit of passing the string containing the text of the verse to the Scripture constructor rather than passing it a List of Word objects?
    A: It puts all of the logic around how the scripture works internally inside the Scripture class.*/
    /* A class for a Scripture will need a constructor that accepts both a reference and the text of the scripture. If the Scripture class internally stores a List of Word objects, the first thought would be to pass a List<Word> variable to the constructor. While this could work, it would have some downsides. First, it would expose the internal storage of the Scripture to the person using the class (losing the benefits of encapsulation). Second, it would require the person using the class to do the work of splitting their text into the list, the way this class expects it. Not only is this extra work, but it also breaks the principle of encapsulation, and will limit your ability to change your class in the future.

    Instead of passing in a list of words, it would better align with the principle of encapsulation to pass in a string that is the text of the scripture. Then, the constructor would have the responsibility of creating the list, and splitting up the words in the string to create Word objects for each one and put them in the list.

    While including the logic of creating the word list may seem like a lot of work for the constructor, it is helpful to encapsulate this logic in the Scripture class so that other code does not have to worry about the internal storage of the Scripture. This would enable the program to be easily changed in the future, if a different implementation choice were made. */

    // Source: https://www.techiedelight.com/split-a-delimited-string-into-a-list-in-csharp/#:~:text=In%20LINQ%2C%20you%20can%20use,call%20the%20ToList()%20method.&text=The%20above%20solution%20returns%20a%20list%20of%20strings.
    public Scripture(Reference reference, string text) // ???
    {
        _reference = reference;

        // split text and add to new list
        List<string> result = text.Split(' ').ToList(); // String.Join(" ", result)

        // add to the words list
        foreach (string i in result)
        {
            Word word = new Word(i);
            _words.Add(word);
        }

    }

    // Behaviors:
    // HideRandomWords(numberToHide : int) : void
    // call the Hide() method on the Word objects
    public void HideRandomWords(int numberToHide)
    {

    }

    // GetDisplayText() : string      // String.Join(" ", result)
    // text with some words shown normally, and some replaced by underscores.

    // string newString = new string('_', oldString.Length);
    // Source: https://stackoverflow.com/questions/1617260/c-sharp-count-string-length-and-replace-each-character-with-another
    public string GetDisplayText() // ?????????
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }

        return $"{_reference.GetDisplayText()} {scriptureText}"; 
    }

    // IsCompletelyHidden() : bool
    public bool IsCompletelyHidden()
    {
        return false;
    }
}