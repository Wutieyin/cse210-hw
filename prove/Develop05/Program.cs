using System;
using System.Collections.Generic;
using System.IO;


public enum GoalType
{
    Simple,
    Eternal,
    Checklist
}

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}