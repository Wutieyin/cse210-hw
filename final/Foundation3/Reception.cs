class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
        : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullMessage()
    {
        return base.GetFullMessage() + $"\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
