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
        protected List<Goal> _goals = new List<Goal>();
        public Goal(){}

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public string GetName()
        {
            return $"{_name}";           
        }

        protected string GetDescription()
        {
            return _description;           
        }

        protected int GetPoints()
        {
            return _points;
        }
        
        
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
    }
}