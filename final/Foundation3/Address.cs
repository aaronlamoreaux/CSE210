public class Address
{
    private string _address = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public Address()
    {

    }

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }
    public string FullAddress()
    {
        string fullAddress = $"{GetAddress()} {GetCity()}, {GetState()}, {GetCountry()}";
        return fullAddress;
    }
}