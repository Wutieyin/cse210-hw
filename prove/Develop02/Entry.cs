using System;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Reflection.Metadata.Ecma335;

public class Entry
{

  //This is prep 2
  
  
  public string _entryText = "";
  public string _promptText = ""; 
  public string _date = "";
  

  public void Display()  
  {
      Console.WriteLine($"Date: {_date} - {_promptText}, {_entryText}");
  }
}