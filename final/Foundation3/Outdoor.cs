public class Outdoor : Event
{
    private string _weather = "";

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        SetEventType("Outdoor");
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string EventDetails()
    {
        string eventDetail = $"{StandardDetails()}\nForecast: {_weather}";
        return eventDetail;
    }
}