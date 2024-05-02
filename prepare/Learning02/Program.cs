using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //This is prep 2

        Console.WriteLine();
        Job job1 = new Job();
        job1._jobTile = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTile = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job2.DisplayJobDetails();

        Resume myResume = new Resume(); 
        myResume._name = "Allison Rose";
        //List<Job>_jobs = new List<Job>();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
        
    }
}