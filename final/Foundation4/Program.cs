using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        // list to hold all instances of activities
        List<Activity> activities = new List<Activity>();

        // create at least one activity of each type
        // CYCLING
        Cycling cycling = new Cycling("12 Jul 2023", "Cycling", 30, 20);

        // RUNNING
        Running running = new Running("15 Jul 2023", "Running", 30, 4.8);

        // SWIMMING
        Swimming swimming = new Swimming("18 Jul 2023", "Swimming", 30, 30);

        // add the instance to the list
        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        // iterate through this list and call the GetSummary method on each item and display the results.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}