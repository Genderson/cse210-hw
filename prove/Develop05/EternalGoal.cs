using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points){}


        public override string DisplayFullGoalDescription()
        {
            return $"[ ] {GetName()} ({GetDescription()})";           
        }

        public override int RecordEvent()
        {
            return GetPoints();
        }
    }
}