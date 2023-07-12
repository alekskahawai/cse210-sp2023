using System;

// Supplies random prompts whenever needed.
public class PromptGenerator
{
    // Create the member variable _prompts.
    public List<string> _prompts;

    // list of prompts
    // Source: https://www.loginradius.com/blog/engineering/list-csharp/
    public PromptGenerator()
    {
        // Source: 'Primary Greatness' by Stephen R. Covey (2015).
        _prompts = new List<string> // 7 questions in the list
        {
            "What small steps can you take today to improve a key relationship at work and at home?",
            "What can you do to make your own work team more complementary?",
            "Describe an unusually creative or synergistic experience you have had.",
            "Are you committed to both personal and professional development on a continuous basis? Describe.",
            "What opportunities could you take advantage of to increase your learning?",
            "What would you do if you knew your knowledge would be obsolete in three years?",
            "How can you increase your opportunities for teaching to learn?"
        };
    }
    

    // generate prompts
    public string GetRandomPrompt()
    {
        // get random number for index in list of prompts
        Random randomGenerator = new Random();
        int indexNumber = randomGenerator.Next(0, 7);

        // store random prompt from the list
        string randomPrompt = _prompts[indexNumber];

        return randomPrompt;
    }
}