class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

       public override double GetLaps()
    {
        return _laps;
    }


    public override double GetDistance()
    {
        return GetLaps() * 50 / 1000; // converting meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / duration * 60 * 60; // converting km/h from km/min
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }

  
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}
