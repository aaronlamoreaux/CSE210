public class Video
{
    private string _title = "";
    private string _author = "";
    private double _length = 0;
    private List<Comments> _comments = new List<Comments>();
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public static double GetNumberOfComments(List<Comments> comments)
    {
        return comments.Count();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public double GetLength()
    {
        return _length;
    }

    public void NewComment(string author, string text)
    {
        _comments.Add(new Comments(author, text));
    }

    public void Display()
    {
        Console.WriteLine($"{GetTitle()}\nby {GetAuthor()}.\nThis video is {GetLength()} seconds long. \nThis video has {GetNumberOfComments(_comments)} comments: ");
        foreach (var comment in _comments)
        {
            comment.Display();
        }
    }
}