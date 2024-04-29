using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        int yourNumber = -9000000;
        while (yourNumber != 0)
        {
        Console.Write("Enter number: ");
        string enterAction = Console.ReadLine();
        yourNumber = int.Parse(enterAction);
            if (yourNumber != 0)
            {
                numbers.Add(yourNumber);
            }
        }
        
        // Part 1: Compute the sum.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Find the average.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        int min = numbers[0];

        // Part 3: Find the lagerst number.
        foreach (int number in numbers)
        {
            if (max < number)
            {
                // if the max is less than the number, the number becomes the new max!
                max = number;
                
            }

        }

        // Part 4: Find the smallest positive number.     
        foreach (int number in numbers)
        {
            if (min > number && number > 0)
            {
                // if the min is greater than the number, the number becomes the new min 
                //as long as its greater than 0!
                min = number;   
            }

        }
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");
        Console.WriteLine();
        
    }
}