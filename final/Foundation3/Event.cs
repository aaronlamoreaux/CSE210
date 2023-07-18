public class Event
{
    private string _eventTitle = "";
    private string _eventType = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private Address _address = new Address();

    public Event(string title, string description, string date, string time, Address address)
    {
        _address = address;
        _date = date;
        _description = description;
        _eventTitle = title;
        _time = time;
    }

    public string GetTitle()
    {
        return _eventTitle;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public string GetDes()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address.FullAddress();
    }

    public void SetEventType(string type)
    {
        _eventType = type;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string StandardDetails()
    {
        string standardDetails = $"Event: {GetTitle()}\n{GetDes()}\nWhen? {GetDate()} at {GetTime()}\nWhere? At {GetAddress()}";
        return standardDetails;
    }

    public string ShortDescription()
    {
        string description = $"{GetEventType()} {GetTitle()} At {GetDate()}";
        return description;
    }
}