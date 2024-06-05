class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        
    }

       public override double GetLaps()
    {
        return 1;
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
