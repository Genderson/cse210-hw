using System;
using Develop05;


class Program
{
    /*EXCEEDS REQUIREMENTS
    1. I added a new type of goal called Expire goal. In this new goal type, the user needs to specify an expiration date and the goal must be completed before that day. If not, the goal is closed
    2. I used the factory pattern to recreate the Goals objects based on the data stored in the file
    */
    
    private enum TypeOfGoals { SimpleGoal = 1, EternalGoal, ChecklistGoal, ExpireGoal }
    private static List<Goal> _goals = new List<Goal>();
    private static Develop05.File _file = new Develop05.File();
    private static int _points = 0;
    static void Main(string[] args)
    {
        string option = string.Empty;
        Console.Clear();

        while (option != "6")
        {
            Console.WriteLine($"You have {_points} points\n");

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
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoals();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6"://Quit
                    Console.WriteLine("have a good day !!!\n");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Expire Goal\n");

        Console.Write("Which type of goal would you like to create? ");
        var typeOfGoal = Enum.Parse(typeof(TypeOfGoals), Console.ReadLine());

        if (typeOfGoal.Equals(TypeOfGoals.SimpleGoal))
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.AddGoalData();
            _goals.Add(simpleGoal);
        }
        else if (typeOfGoal.Equals(TypeOfGoals.EternalGoal))
        {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.AddGoalData();
            _goals.Add(eternalGoal);
        }
        else if (typeOfGoal.Equals(TypeOfGoals.ChecklistGoal))
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.AddGoalData();
            _goals.Add(checklistGoal);
        }
        else if (typeOfGoal.Equals(TypeOfGoals.ExpireGoal))
        {
            ExpireGoal expireGoal = new ExpireGoal();
            expireGoal.AddGoalData();
            _goals.Add(expireGoal);
        }

        Console.Clear();
    }

    private static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("The Goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayFullGoalDescription()}");
        }

        Console.WriteLine();
    }

    private static void SaveGoals()
    {
        Console.Write($"What is the file name for the goal file? ");
        _file.SaveToFile(Console.ReadLine(), _goals, _points);
        Console.Clear();
    }

    private static void LoadGoals()
    {
        Console.Write($"What is the file name for the goal file? ");
        var data = _file.LoadFromFile(Console.ReadLine());
        _points = data.Item1;
        _goals.Clear();
        _goals = data.Item2;
        Console.Clear();
    }

    private static void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            string completedText = _goals[i].CheckIfCompleted() ? " (already completed or expired)" : "";
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()} {completedText}");
        }

        Console.Write("Which goal did you accomplish? ");

        int goalSelected = int.Parse(Console.ReadLine());
        var goal = _goals[goalSelected - 1];

        if (goal.CheckIfCompleted())
        {
            Console.WriteLine("\nThis goal is already completed or expired. You need to choose another goal");
        }
        else
        {
            _points += goal.RecordEvent();
        }

        Console.WriteLine();
    }
}