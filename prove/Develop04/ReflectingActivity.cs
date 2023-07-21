// Keeps track of a single word and whether it is shown or hidden.
public class ReflectingActivity : Activity
{
    // Attributes:
    private List<string> _prompts;
    private List<string> _questions;

    // constructor
    /* In addition to initializing the variables, the constructors for the ListingActivity and the ReflectingActivity need to initialize the list of prompts (and questions for the Reflecting activity) and populate them with values. */
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
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

    // GetRandomQuestion() : string
    public string GetRandomQuestion()
    {
        return "";
    }

    // DisplayPrompt() : void
    public void DisplayPrompt()
    {

    }

    // DisplayQuestions() : void
    public void DisplayQuestions()
    {

    }
}