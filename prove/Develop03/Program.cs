using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a scripture object
        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Wait for user input to hide words
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide a few random words
            scripture.HideRandomWords(3);

            // Clear console and display scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("All words are hidden. Press any key to exit.");
        Console.ReadKey();
    }
}