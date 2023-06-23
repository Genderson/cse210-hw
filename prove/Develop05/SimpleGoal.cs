using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private bool _isCompleted;
        public SimpleGoal()
        {
            _isCompleted = false;
        }

        public void SetIsCompleted() => _isCompleted = true;

        public override string DisplayFullGoalDescription()
        {
            return $"[{CheckIfCompleted()}] {_name} ({_description}) ";
        }

        public override int RecordEvent()
        {
            SetIsCompleted();
            return _points;
        }

        public override void AddGoalData()
        {
            base.ProcessGoal();
        }

        private string CheckIfCompleted()
        {
            return _isCompleted ? "X" : " ";
        }
    }
}