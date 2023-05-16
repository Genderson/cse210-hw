using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        Fraction test2 = new Fraction(5);
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());

        Fraction test3 = new Fraction(3, 4);
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        Fraction test4 = new Fraction(1, 3);
        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());
    }
}