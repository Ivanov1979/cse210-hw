using System;

namespace YouTubeVideos
{
    /// <summary>
    /// Represents a single comment on a video.
    /// Responsibility: store the commenter name and the comment text.
    /// </summary>
    public class Comment
    {
        public string CommenterName { get; set; }
        public string Text { get; set; }

        public Comment(string commenterName, string text)
        {
            CommenterName = commenterName;
            Text = text;
        }

        public void Display()
        {
            Console.WriteLine($"- {CommenterName}: {Text}");
        }
    }
}
