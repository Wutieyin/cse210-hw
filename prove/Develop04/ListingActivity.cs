class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    

    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        Console.WriteLine("Start listing:");
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private void GetListFromUser()
    {
        Console.WriteLine("Start listing items. Press Enter after each item. Press Enter twice to finish.");
        string input = Console.ReadLine();
        while (!string.IsNullOrWhiteSpace(input))
        {
            _count++;
            input = Console.ReadLine();
            
        }
    }
}

