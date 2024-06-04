using System;
using System.Security.Cryptography.X509Certificates;

class RandomTextGenerator
{
    public List<string> _randomTexts = new List<string>();


    public string GetRandomText()

    { 
        Random random = new Random();
        int i = random.Next(0, 4);
        Console.Write("\n ", _randomTexts[i]);
        return _randomTexts[i];
    }
}