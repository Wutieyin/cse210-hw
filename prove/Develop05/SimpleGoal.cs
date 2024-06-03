// Derived class representing a simple goal
public class SimpleGoal : Goal
{
    public bool _isComplete;
    private int _bonus = 0;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}"; //{_points}"; //({(_isComplete ? "Achieved" : "Not Achieved")})";
    }

     public int Bonus
    {
        get { return _bonus; }
    }
}