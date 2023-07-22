
public class ListingActivity : Activity
{
    // Attributes:
    private int _count;
    private List<string> _prompts;

    // constructor
    /* In addition to initializing the variables, the constructors for the ListingActivity and the ReflectingActivity need to initialize the list of prompts (and questions for the Reflecting activity) and populate them with values. */
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    // Behaviors:
    // Run() : void
    public void Run()
    {

    }

    // GetRandomPrompt() : string
    public string GetRandomPrompt()
    {
        return "";
    }

    // GetListFromUser() : List<string>
    
}