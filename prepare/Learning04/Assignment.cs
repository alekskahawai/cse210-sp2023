using System;

// base class
public class Assignment
{
    // Add the attributes as private member variables.
    private string _studentName;
    private string _topic;

    // Create a constructor for this class that receives a student name and topic and sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Add the method for GetSummary() to return the student's name and the topic.
    // Sample Output: Samuel Bennett - Multiplication
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}   