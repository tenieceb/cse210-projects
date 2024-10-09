
public class Comment
{
    public string _commenter;
    public string _commentText;

    public void DisplayCommentText()
    {
        
        Console.WriteLine($"Commenter: {_commenter}");
        Console.WriteLine($"{_commentText}");
    }

    internal string[] Split(string v)
    {
        throw new NotImplementedException();
    }
}