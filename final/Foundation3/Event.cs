class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
       
    }

    public string GetStandardMessage()
    {
        return "";
    }

    public virtual string GetFullMessage()
    {
        return "";
    }

    public virtual string GetShortDescription()
    {
        return "";
    }
}
