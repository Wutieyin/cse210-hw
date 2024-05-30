class Program
{
    static void Main(string[] args)

    {
    int choice = 0;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        string number = Console.ReadLine();
        choice = int.Parse(number);

        
        {
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

             else if (choice == 4)
            {
                Console.WriteLine("Exiting...");
            }
                
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
            }
               
        }
        Console.WriteLine();
    } while (choice != 4);
    }
}

