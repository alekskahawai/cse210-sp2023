using System;

// Create the Resume class.
public class Resume
{
    // Create the member variable for the person's name.
    public string _name;

    /* Create the member variable for the list of Jobs. 
    (Hint: the data type for this should be List<Job> , and it is probably easiest to initialize this to a new list right when you declare it..) */
    public List<Job> _jobs = new List<Job>();

    // add a method to display its details.
    public void DisplayResume()
    {
        /* In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them. 
        Sample Output

        Name: Allison Rose
        Jobs:
        Software Engineer (Microsoft) 2019-2022
        Manager (Apple) 2022-2023
        */
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}