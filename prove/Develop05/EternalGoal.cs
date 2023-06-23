using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        public EternalGoal() { }

        public override void AddGoalData()
        {
            base.ProcessGoal();
        }

        public override string DisplayFullGoalDescription()
        {
            return $"[ ] {_name} ({_description})";
        }

        public override int RecordEvent()
        {
            return GetPoints();
        }
    }
}