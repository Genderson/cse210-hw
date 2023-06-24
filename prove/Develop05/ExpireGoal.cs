
namespace Develop05
{
    public class ExpireGoal : Goal
    {
        string _expirationDate;
        private bool _isCompleted;
        public ExpireGoal()
        {
            _isCompleted = false;
            _expirationDate = string.Empty;
        }

        public ExpireGoal(string name, string description, int points, string expirationDate, bool isCompleted) : base(name, description, points)
        {
            _isCompleted = isCompleted;
            _expirationDate = expirationDate;
        }

        public void SetIsCompleted() => _isCompleted = true;

        public override void AddGoalData()
        {
            base.ProcessGoal();

            Console.Write("What is the expiration date (format: MM/dd/YYYY) ? ");
            _expirationDate = Console.ReadLine();
        }
        public override bool CheckIfCompleted() => _isCompleted || DateTime.Now > DateTime.Parse(_expirationDate); 
        public override string DisplayFullGoalDescription() => $"[{GetMarkIfCompleted()}] {_name} ({_description}) ";
        public override string FormatTextToFile() => $"ExpireGoal|{_name}|{_description}|{_points}|{_expirationDate}|{_isCompleted}";

        public override int RecordEvent()
        {
            SetIsCompleted();
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }

        private string GetMarkIfCompleted() => _isCompleted ? "X" : " ";
    }
}