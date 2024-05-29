using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment assignment1 = new Assignment("Samuel Benneth", "Multiplication");
        System.Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();
        
        MathsAssignment assignment2 = new MathsAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(assignment2.GetSummary()); 
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        WrittingAssignment assignment3 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        System.Console.WriteLine(assignment3.GetSummary());
        System.Console.WriteLine(assignment3.GetWrittingInformation());
        Console.WriteLine();

        

    }
}