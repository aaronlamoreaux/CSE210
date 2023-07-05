public class Customer
{
    private string _name = "";
    Address _address = new Address();

    public Customer()
    {
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsUsa()
    {
        _address.SetUsa();
        bool usa = _address.GetUsa();
        return usa;
    }
}