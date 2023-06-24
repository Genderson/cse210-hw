
namespace Develop05
{
    public class EternalGoal : Goal
    {
        public EternalGoal() { }

        public EternalGoal(string name, string description, int points):base(name, description, points) {}

        public override void AddGoalData() => base.ProcessGoal();
        public override string DisplayFullGoalDescription() => $"[ ] {_name} ({_description})";
        public override int RecordEvent()
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        public override bool CheckIfCompleted() => false;
        public override string FormatTextToFile() => $"EternalGoal|{_name}|{_description}|{_points}";
    }
}