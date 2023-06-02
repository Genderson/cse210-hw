using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();

        Assignment assigmentMultiplication = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigmentMultiplication.GetSummary());

        Console.WriteLine();

        MathAssignment assigmentFraction = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assigmentFraction.GetSummary());
        Console.WriteLine(assigmentFraction.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment assigmentHistory = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assigmentHistory.GetSummary());
        Console.WriteLine(assigmentHistory.GetWritingInformation());
    }
}