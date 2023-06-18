using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        string name = string.Empty;
        string description = string.Empty;
        int points;

        List<Goal> goals = new List<Goal>();

        string option = string.Empty;
        Console.Clear();

        while (option != "6")
        {            
            Console.WriteLine("You have 0 points\n");

            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");

            Console.Write("Please, select a choice from the menu: ");

            option = Console.ReadLine();

            switch (option)
            {
                case "1": // Create a new goal
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal\n");

                    Console.Write("Which type of goal would you like to create? ");
                    string typeOfGoal = Console.ReadLine();

                    if (typeOfGoal == "1") //Simple Goal
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        description = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        points = int.Parse(Console.ReadLine());

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        goals.Add(simpleGoal);

                        Console.Clear();
                    }
                    else if(typeOfGoal == "2")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        description = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        points = int.Parse(Console.ReadLine());

                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        goals.Add(eternalGoal);

                        Console.Clear();
                    }
                    else if(typeOfGoal == "3")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        description = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        points = int.Parse(Console.ReadLine());

                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int times = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonus = int.Parse(Console.ReadLine());

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, times, bonus);
                        goals.Add(checklistGoal);

                        Console.Clear();
                    }
                    break;

                case "2": //List goals
                    Console.Clear();
                    Console.WriteLine("The Goals are:");

                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].DisplayFullGoalDescription()}");
                    }

                    Console.WriteLine();

                    break;

                case "3": //Save goals
                    break;

                case "4": //Load goals
                    break;

                case "5": //Record event
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                    }

                    Console.Write("Which goal did you accomplish? ");
                    typeOfGoal = Console.ReadLine();

                    break;

                case "6"://Quit
                    break;
            }
        }


    }
}