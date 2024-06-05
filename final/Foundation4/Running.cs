class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        
    }

    public override double GetDistance()
    {
        return 1;
    }

    public override double GetSpeed()
    {
        return 1;
    }

    public override double GetPace()
    {
        return 1;
    }

    public override string GetSummary()
    {
        return "";
    }
}
