using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine();
        Console.WriteLine("Welcome to the program!");
        string name = PromptUserName("name");
        int number = PromptUserNumber("yournumber");
        int squareOfNumber = SquareNumber(number);
        DisplayResult(name, squareOfNumber);
        
    }

    public static string PromptUserName(string name)
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        return name;
    }

    public static int PromptUserNumber(string yournumber)
    {
        Console.Write("Please enter your favorite number: ");
        yournumber = Console.ReadLine();
        int number = int.Parse(yournumber);
        return number;
    }

    public static int SquareNumber(int number)
    {
        int squareOfNumber = number * number;
        return squareOfNumber;
    }

    public static void DisplayResult(string name, int squareOfNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareOfNumber}");
        Console.WriteLine();
    }

}