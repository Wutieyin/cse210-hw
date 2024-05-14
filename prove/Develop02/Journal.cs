using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;



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
         foreach(Entry anEntry in _entries)
        {
          
          outputFile.WriteLine($"Date: {anEntry._date} - {anEntry._promptText} {anEntry._entryText}");
        }
          
      }
  }


  public void LoadFromFile(string filename )
  {
    filename = "myFile.txt";

    StreamReader reader = new StreamReader(filename);

    string line = reader.ReadLine();

    while (line != null)
    {
      Console.WriteLine(line);

      line = reader.ReadLine();
    }
    reader.Close();

  }

}