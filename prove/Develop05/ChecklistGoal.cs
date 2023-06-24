
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

        public ChecklistGoal(string name, string description, int points, int times, int timesCompleted, int bonus):base(name, description, points) 
        {
            _times = times;
            _timesCompleted = timesCompleted;
            _bonus = bonus;
        }

        public void RecordTimeCompleted() => _timesCompleted = _timesCompleted + 1;
        public override string DisplayFullGoalDescription() => $"[{GetMarkIfCompleted()}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_times}";

        public override int RecordEvent()
        {
            RecordTimeCompleted();
            int totalPoints = _timesCompleted >= _times ? _points + _bonus : _points;
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
            return totalPoints;
        }

        public override void AddGoalData()
        {
            base.ProcessGoal();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            _times = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            _bonus = int.Parse(Console.ReadLine());
        }

        public override bool CheckIfCompleted() => _timesCompleted >= _times;
        public override string FormatTextToFile() => $"ChecklistGoal|{_name}|{_description}|{_points}|{_times}|{_timesCompleted}|{_bonus}";

        private string GetMarkIfCompleted() => _timesCompleted >= _times ? "X" : " ";

    }
}