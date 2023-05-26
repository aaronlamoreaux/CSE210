public class Scripture
{
    private string _scripture = "";
    private string _verse = "";
    
    public Scripture(Reference refer, Words words)
    {
        SetVerse(refer, words);
    }

    public string GetVerse()
    {
        return _scripture;
    }

    public void SetVerse(Reference refer, Words words)
    {
        string verse = " ";

        foreach (string word in words.GetVerse())
        {
            verse += word + " ";
        }

        _verse = verse;

        _scripture = refer.GetVerse() + _verse;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{_scripture}");
    }
}