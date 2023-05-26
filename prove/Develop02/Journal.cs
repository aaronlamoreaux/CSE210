public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public Journal()
    {
    }

    public void Display()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }
}