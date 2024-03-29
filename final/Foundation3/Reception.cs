public class Reception : Event
{
    private string _email = "";

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        SetEventType("reception");
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string EventDetails()
    {
        string eventDetail = $"{StandardDetails()}\nRSVP at {GetEmail()}";
        return eventDetail;
    }
}