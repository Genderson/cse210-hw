using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;
        
        public Goal(){}

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public string GetName() => $"{_name}";
        protected virtual void ProcessGoal()
        {
            Console.Write("What is the name of your goal? ");
            _name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            _points = int.Parse(Console.ReadLine());
        }

        public abstract string DisplayFullGoalDescription();
        public abstract int RecordEvent();
        public abstract void AddGoalData();
        public abstract bool CheckIfCompleted();
        public abstract string FormatTextToFile();
    }
}