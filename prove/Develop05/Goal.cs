using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goal
    {
        protected string _name;
        private string _description;
        private int _points;

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
        
        public abstract string DisplayFullGoalDescription();
        public abstract int RecordEvent();

    }
}