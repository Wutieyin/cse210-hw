

// Class representing the goal manager
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private List<ChecklistGoal> _checklistGoals;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _checklistGoals = new List<ChecklistGoal>();
        _score = 0;
    }

    // Start the goal manager
    public void Start()
    {
        //LoadGoals();
        //DisplayPlayerInfo();
        RunMenu();
    }

    // Display player's score and goal details
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    // Run the main menu
    public void RunMenu()
    {
        bool quit = false;
        while (!quit)
        {   
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }

    // Create a new goal based on user input
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? Enter number: ");
        string choice = Console.ReadLine();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Points for Goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter Target for Checklist Goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Points for Checklist Goal: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // List all goals
    public void ListGoals()
    {
        Console.WriteLine("\nList of Goals:");
        /*foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }*/

        /*for (int i = 0; i + 1 <= _goals.Count;i++)
        {
            Console.WriteLine($"{i}. [ ] {_goals[i]} ");
        } */
        int index = 1;
        foreach (Goal goal in _goals)

        if (goal.IsCompleted() == false)
        {
            Console.WriteLine($"{index++}. [ ] {goal.GetDetailsString()}");
        }

        else if (goal.IsCompleted() == true)
        Console.WriteLine($"{index++}. [X] {goal.GetDetailsString()}");
    }

    // Save goals to a file
    public void SaveGoals()
    {
        Console.Write("Enter file name to save goals: ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string goalType = goal.GetType().Name;
                string goalDetails = goalType switch
                {
                    "SimpleGoal" => $"{goalType}: {goal.GetStringRepresentation()}, {goal.GetPoints()},{goal.IsCompleted()}",
                    "EternalGoal" => $"{goalType}: {goal.GetStringRepresentation()}, {goal.GetPoints()}",
                    "ChecklistGoal" => $"{goalType}: {goal.GetStringRepresentation()}, {goal.GetPoints()}, {((ChecklistGoal)goal).Target}, {((ChecklistGoal)goal).Bonus}, {((ChecklistGoal)goal).AmountCompleted}", 
                    _ => ""
                };
                writer.WriteLine(goalDetails);
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    // Load goals from a file
    public void LoadGoals()
    {
        Console.Write("Enter file name to load goals: ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0].Trim();
                    string goalData = parts[1].Trim();
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            string[] simpleGoalData = goalData.Split(',');
                            _goals.Add(new SimpleGoal(simpleGoalData[0].Trim(), simpleGoalData[1].Trim(), int.Parse(simpleGoalData[2].Trim())) { _isComplete = bool.Parse(simpleGoalData[3].Trim()) });
                            break;
                        case "EternalGoal":
                            string[] eternalGoalData = goalData.Split(',');
                            _goals.Add(new EternalGoal(eternalGoalData[0].Trim(), eternalGoalData[1].Trim(), int.Parse(eternalGoalData[2].Trim())));
                            break;
                        case "ChecklistGoal":
                            string[] checklistGoalData = goalData.Split(',');
                            _goals.Add(new ChecklistGoal(checklistGoalData[0].Trim(), checklistGoalData[1].Trim(), int.Parse(checklistGoalData[2].Trim()), int.Parse(checklistGoalData[3].Trim()), int.Parse(checklistGoalData[4].Trim())) { _amountCompleted = int.Parse(checklistGoalData[5].Trim()) });
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Record an event (accomplished goal)
    public void RecordEvent()
    {
    
        Console.WriteLine("\nChoose Goal to Record Event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            _score +=  selectedGoal.GetPoints();
            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsBonusAchieved())
            {
                _score += checklistGoal.Bonus;
            }
            Console.WriteLine($"Event recorded for goal: {selectedGoal.GetStringRepresentation()}. You earned {selectedGoal.GetPoints()} points.");
            
        }  

        else
        {
            Console.WriteLine("Invalid choice.");
        }

    }
}