public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    List<Comment> _comments = new List<Comment>();

    public Video(string _title, string _author, int _lengthInSeconds)
    {
        title = _title;
        author = _author;
        lengthInSeconds = _lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void getComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }

    public int getCommentsCount()
    {
        return _comments.Count;
    }
}