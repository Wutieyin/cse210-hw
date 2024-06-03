// Enum to represent the type of goals


// Base class representing a goal
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public int GetPoints() // Additional method
    {
        return _points;
    }

    public void SetPoints(int Points) // Additional method
    {
        _points = Points;
    }

     public string GetDescription() // Additional method
    {
        return _description;
    }

    public void SetDescription(string Description) // Additional method
    {
        _description = Description;
    }

    // Virtual methods to be overridden by derived classes
    public virtual void RecordEvent() {}
    public virtual bool IsCompleted() { return false; }
    public virtual string GetDetailsString() { return $"{_name} ({_description})"; }
    public virtual string GetStringRepresentation() { return $"{_name}, ({_description})"; }
}