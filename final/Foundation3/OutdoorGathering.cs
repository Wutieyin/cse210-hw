class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
        : base(title, description, dateTime, address)
    {
        
    }

    public override string GetFullMessage()
    {
        return "";
    }
}
