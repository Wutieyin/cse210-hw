using System;
using System.Security.Cryptography.X509Certificates;

/*class PromptGenerator
{   
        public List<string>_prompts; 
        

        public string GetRandomPrompt()
                
        { 
        Random random = new Random();
        int i = random.Next(0, 7); 
          {
            Console.Write("\n {0} ",_prompts[i]);   
            //Console.ReadLine();
          }
            Console.WriteLine(); 
        return _prompts[i];
        
        } 

} */


class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()

    { 
        Random random = new Random();
        int i = random.Next(0, 7);
        Console.Write("\n ", _prompts[i]);
        return _prompts[i];
    }

}
