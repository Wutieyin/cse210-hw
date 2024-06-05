class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
        : base(title, description, dateTime, address)
    {
        
    }

    public override string GetFullMessage()
    {
        return "";
    }
}
