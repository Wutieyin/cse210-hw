class Customer
{
    private string _name;
    private Address _address;

    public Customer(string Name, Address Address)
    {
        _name = Name;
        _address = Address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string Name
    {
        get { return _name; }
    }

    public Address Address
    {
        get { return _address; }
    }

}
