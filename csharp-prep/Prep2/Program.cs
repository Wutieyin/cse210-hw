using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello Prep2 World!");*/

        Console.WriteLine();
        Console.Write("what was your grade percentage in Maths 108? ");
        string score = Console.ReadLine();
        int mathScore = int.Parse(score);
        int lastDigit = (mathScore % 10) + 1 -1;
        string sign = " ";
        string grade = " "; 
        {   
            
            if (mathScore >= 90)
            {
                grade = "A";
                {
                    if (lastDigit >= 3)
                        
                    {
                        sign = "";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }

                    else 
                    {
                        sign = "-";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }
                }
            }

            else if (mathScore >= 80)
            {
                grade = "B";
                {
                    if (lastDigit >= 7)
                    {
                        sign = "+";
                        Console.WriteLine($"You got a {grade}{sign} grade.");
                    }

                    else if (lastDigit >= 3)
                    {
                        sign = "";
                        Console.WriteLine($"You got a {grade}{sign} grade.");
                    }

                    else
                    {
                        sign = "-";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }
                }
            }

            else if (mathScore >= 70)
            {   
                grade = "C";
                {
                    if (lastDigit >= 7)
                    {
                        sign = "+";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }

                    else if (lastDigit >= 3)
                    {   
                        sign = "";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }

                    else
                    {   
                        sign = "-";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }
                }
                
            }

            else if (mathScore >= 60)
            {
                grade = "D";
                {
                    if (lastDigit >= 7)
                    {   
                        sign = "+";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }

                    else if (lastDigit >= 3)
                    {   
                        sign = "";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }

                    else
                    {   
                        sign = "-";
                        Console.WriteLine($"You got an {grade}{sign} grade.");
                    }
                }
            }

            else
            {
                Console.WriteLine("You got a F grade.");
            }

            
        }

    if (mathScore >= 70)  
    {
        Console.WriteLine("Congratulations! You made it.");
    }

    else 
    {
        Console.WriteLine("Try again next time, I know you can do it.");
    }
        Console.WriteLine();
    }   

}

    
