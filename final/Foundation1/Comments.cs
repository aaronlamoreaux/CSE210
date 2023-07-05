public class Comments
{
    private string _author = "";
    private string _text = "";
    public Comments(string author, string text)
    {
        _author = author;
        _text = text;
    }


    public string GetAuthor()
    {
        return _author;
    }


    public string GetText()
    {
        return _text;
    }

    public void Display()
    {
        Console.WriteLine($"{GetAuthor()}: \n{GetText()}");
    }
}