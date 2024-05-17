using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        System.Console.WriteLine();
        Fraction fraction = new Fraction();
        System.Console.WriteLine(fraction.GetFractionString());
        System.Console.WriteLine(fraction.GetDecimalValue());
        System.Console.WriteLine();

        Fraction fraction2 = new Fraction(5);
        System.Console.WriteLine(fraction2.GetFractionString());
        System.Console.WriteLine(fraction2.GetDecimalValue());
        System.Console.WriteLine();

        Fraction fraction3 = new Fraction(3, 4);
        System.Console.WriteLine(fraction3.GetFractionString());
        System.Console.WriteLine(fraction3.GetDecimalValue());
        System.Console.WriteLine();

        Fraction fraction4 = new Fraction(1, 3);
        System.Console.WriteLine(fraction4.GetFractionString());
        System.Console.WriteLine(fraction4.GetDecimalValue());
        System.Console.WriteLine();
    }
}