
namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private bool _isCompleted;
        public SimpleGoal() => _isCompleted = false;

        public SimpleGoal(string name, string description, int points, bool isCompleted):base(name, description, points)
        {
            _isCompleted = isCompleted; 
        }

        public void SetIsCompleted() => _isCompleted = true;

        public override string DisplayFullGoalDescription() => $"[{GetMarkIfCompleted()}] {_name} ({_description}) ";
        public override int RecordEvent()
        {
            SetIsCompleted();
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }

        public override void AddGoalData() => base.ProcessGoal();     
        public override bool CheckIfCompleted() => _isCompleted;
        public override string FormatTextToFile() => $"SimpleGoal|{_name}|{_description}|{_points}|{_isCompleted}";

        private string GetMarkIfCompleted() => _isCompleted ? "X" : " ";
    }
}