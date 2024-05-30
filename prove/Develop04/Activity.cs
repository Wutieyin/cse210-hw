using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public virtual void DisplayStartingMessage()
    {   Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} Activity:");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        Thread.Sleep(3000);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            
            Console.Write(".");
            Thread.Sleep(1000);
            
            /*
            Console.Write("+");
            Thread.Sleep(500);

            Console.WriteLine("\b \b");
            Console.WriteLine("-");
            */

        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}

