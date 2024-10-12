using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength;
    //in seconds
    public List<Comment> _commentList = new List<Comment>();

    public void DisplayVideoDetails ()
    {

        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor} ");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        foreach (Comment comment in _commentList)
        {
            
            comment.DisplayCommentText();
        }
    }

    public void CreateCommentList(List <string> comment)
    {

        _commentList.Clear();

        foreach (string line in comment)
        {
            string[] parts = line.Split(",");

            Comment newComment = new Comment();
            newComment._commenter = parts[0];
            newComment._commentText = parts[1];

            _commentList.Add(newComment);
            
        }

    }


    public int NumberOfComments()
    {
        return _commentList.Count;
    }
}