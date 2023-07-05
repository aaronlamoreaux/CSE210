public class Address
{
    private string _address = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    private bool _usa = false;

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

    public bool GetUsa()
    {
        return _usa;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public void SetUsa()
    {
        if (GetCountry() == "USA")
        {
            _usa = true;
        }
    }

    public string FullAddress()
    {
        string fullAddress = $"{GetAddress()}\n{GetCity()}, {GetState()}\n{GetCountry()}";
        return fullAddress;
    }
}