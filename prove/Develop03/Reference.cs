public class Reference
{
    private string _reference = "";
    private string _book = "";
    private string _chapter = "";
    private string _startVerse = "";
    private string _endVerse = "";

    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _reference = _book + " " + _chapter + ":" + _startVerse;
    }

        public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _reference = _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
    }

    public string GetVerse()
    {
        return _reference;
    }
}