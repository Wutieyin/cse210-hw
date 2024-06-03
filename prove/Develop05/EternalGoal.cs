// Derived class representing an eternal goal

public class EternalGoal : Goal
{
    private int _bonus = 0;
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}"; //, {_points}";
    }

     public int Bonus
    {
        get { return _bonus; }
    }
}