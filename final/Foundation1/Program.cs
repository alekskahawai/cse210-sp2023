/* Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list. */

using System;

class Program
{
    static void Main(string[] args)
    {
        // creates 3-4 video instances
        Video video1 = new Video("Cartoon", "Studio1", 500);

        Video video2 = new Video("News today", "Cable45", 600);

        Video video3 = new Video("Comedy", "Production", 1500);

        // add a list of 3-4 comments for each video
        // Source: https://www.lipsum.com
        
        // Video1 comments:
        Comment comment1 = new Comment("refgt23", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc justo.");

        video1.AddComment(comment1);

        Comment comment11 = new Comment("wert455", "In magna sem, venenatis nec ultrices in, aliquam placerat nibh.");

        video1.AddComment(comment11);

        Comment comment111 = new Comment("dfgt12", "Proin lobortis nec nisi sit amet fermentum. Curabitur blandit, arcu.");

        video1.AddComment(comment111);

        // Video2 comments:
        Comment comment2 = new Comment("23refgt", "Ipsum lorem dolor sit amet, consectetur adipiscing elit. Nunc justo.");

        video2.AddComment(comment2);

        Comment comment22 = new Comment("455wert", "Sem in magna, venenatis nec ultrices in, aliquam placerat nibh.");

        video2.AddComment(comment22);

        Comment comment222 = new Comment("12dfgt", "Lobortis proin nec nisi sit amet fermentum. Curabitur blandit, arcu.");

        video2.AddComment(comment222);

        Comment comment2222 = new Comment("65dfgw", "Nec nisi proin lobortis sit amet fermentum. Curabitur blandit, arcu.");

        video2.AddComment(comment2222);

        // Video3 comments:
        Comment comment3 = new Comment("4wert55", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc justo.");

        video3.AddComment(comment3);

        Comment comment33 = new Comment("2refgt3", "Nec ultrices in, aliquam in magna sem, venenatis placerat nibh.");

        video3.AddComment(comment33);

        Comment comment333 = new Comment("1dfgt2", "it amet fermentum proin lobortis nec nisi. Curabitur blandit, arcu.");

        video3.AddComment(comment333);

        // Put each video in a list.
        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        // iterate through the list of videos and display.
        foreach (Video video in _videos)
        {
            video.DisplayAllVideos();
        }
    }
}