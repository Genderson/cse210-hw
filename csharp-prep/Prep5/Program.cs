using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    public static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    public static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    public static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    public static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    public static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}