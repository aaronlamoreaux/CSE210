public class Lecture : Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        SetEventType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public string EventDetails()
    {
        string eventDetail = $"{StandardDetails()}\nSpeaking: {GetSpeaker()}\nCapacity: {GetCapacity()}";
        return eventDetail;
    }
}