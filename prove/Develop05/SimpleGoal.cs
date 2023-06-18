using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private bool _isCompleted;
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isCompleted = false;
        }


        public override string DisplayFullGoalDescription()
        {
            string completed = _isCompleted ? "X" : " "; 
            return $"[{completed}] {GetName()} ({GetDescription()})";           
        }

        public override int RecordEvent()
        {
            throw new NotImplementedException();
        }
    }
}