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

        public ChecklistGoal()
        {
        }

        public void RecordTimeCompleted()
        {
            _timesCompleted += _timesCompleted;
        }

        public override string DisplayFullGoalDescription()
        {
            return $"[{CheckIfCompleted()}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_times}";
        }

        public override int RecordEvent()
        {
            throw new NotImplementedException();
        }

        private string CheckIfCompleted()
        {
            return _timesCompleted >= _times ? "X" : " ";
        }

        public override void AddGoalData()
        {
            base.ProcessGoal();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            _times = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            _bonus = int.Parse(Console.ReadLine());
        }
    }
}