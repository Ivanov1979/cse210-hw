using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    /// <summary>
    /// Represents a YouTube video:
    /// title, author, length in seconds, and its comments.
    /// </summary>
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }

        // Internal list of comments (hidden detail)
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public void DisplayVideoInfo()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {LengthInSeconds} seconds");
            Console.WriteLine($"Comments: {GetNumberOfComments()}");
            Console.WriteLine("---------- Comments ----------");

            foreach (Comment comment in _comments)
            {
                comment.Display();
            }

            Console.WriteLine(); // blank line after comments
        }
    }
}
