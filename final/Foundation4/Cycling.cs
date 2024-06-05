class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        
    }

    public override double GetSpeed()
    {
        return 1;
    }

    public override double GetDistance()
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
