class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        
    }

    public virtual double GetDistance()
    {
        return 1;
    }

    public virtual double GetSpeed()
    {
        return 1;
    }

    public virtual double GetPace()
    {
        return 1;
    }

     public virtual double GetLaps()
    {
        return 1;
    }

    public virtual string GetSummary()
    {
        return "";
    }

    
}
