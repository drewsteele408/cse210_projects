public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds; 

    public string Title => _title;
    public string Author => _author;
    public int LengthInSeconds => _lengthInSeconds; 

    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;


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