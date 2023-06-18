using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        private int _times;
        private int _timesCompleted;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int times, int bonus) : base(name, description, points)
        {
            _times = times;
            _bonus = bonus;
        }

        public void RecordTimeCompleted()
        {
            _timesCompleted += _timesCompleted;
        }

        public override string DisplayFullGoalDescription()
        {
            return $"[{CheckIfCompleted()}] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_times}";     
        }

        public override int RecordEvent()
        {
            throw new NotImplementedException();
        }

        private string CheckIfCompleted()
        {
            return _timesCompleted >= _times ? "X" : " ";
        }
    }
}