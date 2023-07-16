/* Responsibility:
 - track the title, author, and length (in seconds) of the video.
- to store a list of comments, and should have a method to return the number of comments.
 */
public class Video
{
    // Attributes:
    public string _title, _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    // Video Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Behaviors:
    // method to add a new comment
    // call the method by: video.AddComment(comment);
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment); 
    }

    // method to return number of comments for each video
    public int NumberComments(List<Comment> comments)
    {
        int numberComments = comments.Count();

        return numberComments;
    }

    // method to display all videos with relaited comments
    public void DisplayAllVideos()
    {
        /* for each video, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. 
        
        Sample Output:

        Title: Evening News
        Author: CNBS
        Length: 300 sec.
        Number of comments: 3
        User: sdt678
        <Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc justo.>
        */
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} sec.");
        Console.WriteLine($"Number of comments: {NumberComments(_comments)}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}