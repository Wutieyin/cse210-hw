using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

/*class Journal
{
    
        public List<Entry>_entries = new List<Entry>();
        

        public void AddEntry(Entry newEntry)
        {
          _entries.Add(newEntry);
        }

        public void DisplayAll()
                
        {
          foreach (Entry entry in _entries)
          {
            entry.Display();
          }
        } 

        public void SaveToFile(string filename)
        {
          filename = "myFile.txt";

          using (StreamWriter outputFile = new StreamWriter(filename))
          {
              // You can add text to the file with the WriteLine method
              //outputFile.WriteLine("This will be the first line in the file.");
              
              // You can use the $ and include variables just like with Console.WriteLine
              
              outputFile.WriteLine(_entries);
          } 
        }
        

        public void LoadFromFile(string filename)
        {
          filename = "myFile.txt";
          string[] lines = System.IO.File.ReadAllLines(filename);
          foreach (string line in lines)
          {
              string[] parts = line.Split(",");

              /*string _date = parts[0];
              string _promptText = parts[1];
              string _entryText = parts[2];*/
         /* }
        
        }
        
} 
*/


class Journal
{

  public List<Entry> _entries = new List<Entry>();


  public void AddEntry(Entry newEntry)
  {
      //List<Entry>_entries = new List<Entry>();
      _entries.Add(newEntry);
      
  }

  public void DisplayAll()

  {
      foreach (Entry anEntry in _entries)
      {
          anEntry.Display();
      }
  }

  public void SaveToFile(string filename)
  {
      filename = "myFile.txt";

      using (StreamWriter outputFile = new StreamWriter(filename))
      {
          foreach (Entry entry in _entries)
        {
          //outputFile.WriteLine($"Date: {anEntry._date} - {anEntry._promptText} {anEntry._promptText}");
          //outputFile.WriteLine($"My favorite color is {_entries}");
          outputFile.WriteLine($"My favorite color is {entry}");
        }
          
      }
  }


  public void LoadFromFile(string filename)
  {
      filename = "myFile.txt";
      string[] lines = System.IO.File.ReadAllLines(filename);
      foreach (string line in lines)
      {
          string[] parts = line.Split(",");

          string _date = parts[0];
          string _promptText = parts[1];
          string _entryText = parts[2];
      }

  }

}