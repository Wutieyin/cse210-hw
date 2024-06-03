// Derived class representing a checklist goal
public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

/*
    public int GetTarget() // Additional method
    {
        return _target;
    }

    public void SetTarget(int target) // Additional method
    {
        _target = target;
    } */

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsCompleted()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public bool IsBonusAchieved()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}"; //, {_points}, {_target}, {_bonus}, {_amountCompleted}";
    }

    public int Bonus
    {
        get { return _bonus; }
    }

    public int Target
        {
            get { return _target; }
        }

    public int AmountCompleted
        {
            get { return _amountCompleted; }
        }

   
}