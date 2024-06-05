class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
     
    }

    public bool IsInUSA()
    {
        return true;
    }

    public override string ToString()
    {
        return "";
    }

    
}
