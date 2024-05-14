using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Intrinsics.Arm;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the journal Program!");

        Console.WriteLine();
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.WriteLine();
        Console.Write("What would you like to do? ");
        string enterAction = Console.ReadLine();

        int choice = int.Parse(enterAction);

       

        PromptGenerator promptGenerator = new PromptGenerator();
        //Entry anEntry = new Entry();
        Journal myJournal = new Journal();
        
        
        while (choice != 5)
        {
           
            if (choice == 1)
            {
                
                //Console.WriteLine(11111111111);
                string filePath = @"/Users/utieyinwyse/Desktop/BYUI/Programing with Classes/cse210-hw/prove/Develop02/WritingPrompt.txt";

                List<string> _prompts = new List<string>();
                promptGenerator._prompts = File.ReadAllLines(filePath).ToList();
                //Console.WriteLine(22222222222222);

                Entry anEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                anEntry._date = theCurrentTime.ToShortDateString();
                anEntry._promptText = promptGenerator.GetRandomPrompt();

              
                Console.Write($"{anEntry._promptText} ");
                anEntry._entryText = Console.ReadLine();

                
               
                myJournal.AddEntry(anEntry);

            }

            else if (choice == 2)
            {
                myJournal.DisplayAll();
                Console.WriteLine();
            }

            else if(choice == 3)
            {
                Console.Write("what is the file name? ");
                string filename = Console.ReadLine();
                Console.WriteLine();

                if (filename == "myFile.txt")
                {
                    myJournal.LoadFromFile(filename);
                    
                }
            }

            else if(choice == 4)
            {
                System.Console.Write("what is the file name? ");
                string filename = Console.ReadLine();

                if (filename == "myFile.txt")
                {
                    myJournal.SaveToFile(filename);
                }
            } 

            else if (choice == 5)
            {
                System.Console.WriteLine("Thanks for using the Journal today. Good bye.");
            }

            else
            {
                Console.WriteLine("Make sure you choose from the numbers: 1 to 5.");
            } 

            
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices. ");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine();
            Console.Write("What would you like to do? ");
            enterAction = Console.ReadLine();
            choice = int.Parse(enterAction);
            Console.WriteLine();
        }
    }
}