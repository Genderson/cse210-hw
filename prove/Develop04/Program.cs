using System;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        //DisplayHelper.ReverseTimer(5);
        //DisplayHelper.Spinner();
        Console.Clear();
        Console.WriteLine("Menu options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string option = Console.ReadLine();

        Console.Clear();

        if(option.Equals("1", StringComparison.OrdinalIgnoreCase))
        {
            string description = $"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
            string name = "Breathing";

            var breathing = new BreatheActivity(name, description);

            Console.Write(breathing.DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(breathing.DisplayReadyMessage());
            DisplayHelper.Spinner();
            Console.WriteLine();

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));

            while (endTime > DateTime.Now){
                Console.Write(breathing.DisplayBreatheInMessage());
                DisplayHelper.ReverseTimer(4);                
                Console.WriteLine();
                Console.Write(breathing.DisplayBreatheOutMessage());
                DisplayHelper.ReverseTimer(6);

                Console.WriteLine("\n");
            }

            Console.WriteLine(breathing.DisplayWellDoneMessage());
            DisplayHelper.Spinner();
            Console.WriteLine("\n");

            breathing.SetDuration(int.Parse(duration));
            Console.Write(breathing.DisplayEndMessage());
            DisplayHelper.Spinner();
        }
        else if(option.Equals("2", StringComparison.OrdinalIgnoreCase))
        {
            string description = $"This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.";
            string name = "Reflecting";

            var reflect = new ReflectActivity(name, description);

            Console.Write(reflect.DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(reflect.DisplayReadyMessage());
            DisplayHelper.Spinner();
            Console.WriteLine();

            Console.WriteLine("Consider the following promt:\n");
            Console.WriteLine($"--- {reflect.GetRandomPrompt()} ---\n");
            Console.WriteLine($"When you have something in mind, press enter to continue");
            Console.ReadLine();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience");
            Console.Write($"You may begin in: ");
            DisplayHelper.ReverseTimer(5);

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));
            Console.Clear();

            while (endTime > DateTime.Now)
            {
                string question = reflect.GetRandomQuestion();
                Console.Write($"> {question} ");
                DisplayHelper.Spinner();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(reflect.DisplayWellDoneMessage());
            DisplayHelper.Spinner();
            Console.WriteLine("\n");

            reflect.SetDuration(int.Parse(duration));
            Console.Write(reflect.DisplayEndMessage());
            DisplayHelper.Spinner();
        }    
    }
}