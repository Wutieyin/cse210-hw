using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();

        //Part 1: User decides number.
        
        Console.Write("what is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);


        Console.Write("what is your guess? ");
        string guess = Console.ReadLine();
        int yourGuess = int.Parse(guess);
        {

        if (magicNumber > yourGuess)
        {
            System.Console.WriteLine("Higer");
        }

        else if (magicNumber < yourGuess)
        {
            System.Console.WriteLine("Lower");
        }

        else
        {
            System.Console.WriteLine("You guessed it!");
        }
        }
        //Part 1 ends.


        //Part 2 : User decides number and while loop added.
        
        /*
        Console.Write("what is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);
        
        
        int yourGuess = -1;
    
        while (yourGuess != magicNumber) 
        {
        
        Console.Write("what is your guess? ");
        string guess = Console.ReadLine();
        yourGuess = int.Parse(guess);

        if ( magicNumber > yourGuess)
        {
            Console.WriteLine("Higher");   
        } 

        else if (magicNumber < yourGuess)
        {
            Console.WriteLine("Lower");  
        }

        else
        {
            System.Console.WriteLine("You guessed it! ");
        }
        
        }   */
        //Part 2 ends.
    
    
        //Part 3: Random number generator with a do while loop applied.
        /*
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        
        
        int yourGuess;
        

        do 
        {
            Console.WriteLine();

            
            Console.Write("what is your guess? ");
            string guess = Console.ReadLine();
            yourGuess = int.Parse(guess);

            {
        
                if ( magicNumber > yourGuess)
                {
                    Console.WriteLine("Higher");   
                } 

                else if (magicNumber < yourGuess)
                {
                    Console.WriteLine("Lower");  
                }

                else
                {
                    System.Console.WriteLine("You guessed it! ");
                }
            

                Console.WriteLine();
            }
        } while (yourGuess != magicNumber);
       */ 
        
    }
} 