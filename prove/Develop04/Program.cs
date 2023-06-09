using System;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string option = Console.ReadLine();

        if(option.Equals("1", StringComparison.OrdinalIgnoreCase)){

            string description = $"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
            var breathing = new BreatheActivity("Breathing", description);

            Console.WriteLine(breathing.DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Write(duration);
        }
    }
}