/* Responsibility:
- tracking both the name of the person who made the comment and the text of the comment.
 */

public class Comment
{
    // Attributes:
    public string _authorName, _commentText;

    // Comment constructor
    public Comment(string authorName, string commentText)
    {
        _authorName = authorName;
        _commentText = commentText;
    }
    
    // Behaviors:
    // method to display a comment
    public void DisplayComment()
    {
        /* Sample Output:
        User: sdt678
        <Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc justo.> */
        Console.WriteLine($"User: {_authorName}");
        Console.WriteLine($"<{_commentText}>");
    }
}