using System;

// Create the class (Hint this is the public class Job syntax).
public class Job
{
    /* Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle . */
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    /* add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything. By convention, this method should begin with a capital letter, such as Display, and if you have multiple words each word should be capitalized, such as DisplayJobDetails . */
    public void DisplayJobDetails()
    {
        // Displays the job information in the format 
        // "Job Title (Company) StartYear-EndYear"
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
}