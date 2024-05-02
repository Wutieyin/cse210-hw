using System;
using System.Security.Cryptography.X509Certificates;

class Job
{
    
        
        
        public string _company;
        public string _jobTile;
        public int _startYear;
        public int _endYear;

        public void DisplayJobDetails()
                
        {
           Console.WriteLine($"{_jobTile} ({_company}) {_startYear} - {_endYear}");
        } 

    

    

        /*
        Console.WriteLine();
        
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine(); */
    
}