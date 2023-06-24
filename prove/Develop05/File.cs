
namespace Develop05
{
    public class File
    {
        public void SaveToFile(string fileName, List<Goal> goals, int points)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(points);
                foreach (var goal in goals)
                {                    
                    outputFile.WriteLine(goal.FormatTextToFile());
                }                
            }
        }

        public Tuple<int, List<Goal>> LoadFromFile(string fileName)
        {
            List<Goal> goals = new List<Goal>();
            int points = 0;
            string[] lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Count(); i++)
            {
                if (i == 0)
                {
                    points = int.Parse(lines[i]);
                }
                else
                {
                    var goal = GoalFactory.GetGoal(lines[i].Split("|"));
                    goals.Add(goal);
                }
            }
            
            return Tuple.Create(points, goals);
        }
    }
}