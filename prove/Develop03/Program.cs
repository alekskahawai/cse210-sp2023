/* Submission comment.
Code's logic closely follows Instructor's get-started video.  */

// Week 03 Develop: Scripture Memorizer.  Sources:
// byui-cse.github.io/cse210-ww-course-2023/week03/develop.html
// byui-cse.github.io/cse210-ww-course-2023/week03/design.html
// byui-cse.github.io/cse210-ww-course-2023/week03/prepare.html

// Console.Clear() method

/* https://www.churchofjesuschrist.org/manual/book-of-mormon-teacher-resource-manual/appendix/scripture-mastery-lists?lang=eng
Isaiah 29:13-14
Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men:
Therefore, behold, I will proceed to do a marvellous work among this people, even a marvellous work and a wonder: for the wisdom of their wise men shall perish, and the understanding of their prudent men shall be hid.
Matthew 6:24
No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon. */
using System;

class Program
{
    static void Main(string[] args)
    {
        // creat a Reference
        Reference longRef = new Reference("Isaiah", 29, 13, 14);
        Scripture longScript = new Scripture(longRef, "Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men: Therefore, behold, I will proceed to do a marvellous work among this people, even a marvellous work and a wonder: for the wisdom of their wise men shall perish, and the understanding of their prudent men shall be hid.");

        
        // initial display
        Console.Clear();
        Console.WriteLine(longScript.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
        // stopProgram = Console.ReadLine();

        // loop untill user types "quit"
        string stopProgram = "";
        while (stopProgram != "quit")
        {
            Console.Clear();
            Console.WriteLine(longScript.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            stopProgram = Console.ReadLine();
            // Console.Clear();
            // longScript.HideRandomWords(3);
        }
    }
}