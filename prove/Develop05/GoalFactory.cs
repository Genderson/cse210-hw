
namespace Develop05
{
    public class GoalFactory
    {
        public static Goal GetGoal(string[] parameters)
        {
            Goal goal = null;
            
            if(parameters[0].Equals("simplegoal", StringComparison.OrdinalIgnoreCase))
            {
                goal = new SimpleGoal(parameters[1], parameters[2], int.Parse(parameters[3]), bool.Parse(parameters[4]));
            }
            else if(parameters[0].Equals("eternalgoal", StringComparison.OrdinalIgnoreCase))
            {
                goal = new EternalGoal(parameters[1], parameters[2], int.Parse(parameters[3]));
            }
            else if(parameters[0].Equals("checklistgoal", StringComparison.OrdinalIgnoreCase))
            {
                goal = new ChecklistGoal(parameters[1], parameters[2], int.Parse(parameters[3]), int.Parse(parameters[4]), int.Parse(parameters[5]), int.Parse(parameters[6]));
            }
            else if(parameters[0].Equals("expireGoal", StringComparison.OrdinalIgnoreCase))
            {
                goal = new ExpireGoal(parameters[1], parameters[2], int.Parse(parameters[3]), parameters[4], bool.Parse(parameters[5]));
            }

            return goal;
        }
    }
}