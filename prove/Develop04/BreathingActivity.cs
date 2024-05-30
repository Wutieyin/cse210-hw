class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in...");
        ShowCountDown(_duration);
        Console.WriteLine("Breathe out...");
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }
}

