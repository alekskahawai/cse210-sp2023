using System;

class Program
{
    static void Main(string[] args)
    {   
        // Test your class
        /* Create a simple assignment, 
        call the method to get the summary, 
        and then display it to the screen. */
        Assignment homeWork = new Assignment("Aleks Volegovs", "Week 03");
        string summary = homeWork.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();

        // create a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.
        MathAssignment math = new MathAssignment("10.2", "3.2", "John Strong", "Fractions");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        // test WritingAssignment class and GetWritingInformation() method.
        WritingAssignment write = new WritingAssignment("White Fang", "Alice Brook", "English");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}