class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetStandardMessage()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\nTime: {_dateTime.ToShortTimeString()}\nAddress: {_address}";
    }

    public virtual string GetFullMessage()
    {
        return GetStandardMessage();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nEvent: {_title}\nDate: {_dateTime.ToShortDateString()}";
    }
}
