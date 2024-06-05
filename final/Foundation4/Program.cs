using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[] {new Running(new DateTime(2024, 10, 7), 30, 3.0), new Cycling(new DateTime(2024, 10, 7), 45, 20), new Swimming(new DateTime(2024, 10, 7), 60, 15)};

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }   
    }
}
