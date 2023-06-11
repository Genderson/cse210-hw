using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;
        private List<ActivityInformation> _activityCount;
        private readonly File _file;
        private const string FILENAME = "ActivityLog.json";

        public Activity()
        {
            _file = new File();
            LoadFromFile();
        }
        public Activity(string name, string description)
        {
            _file = new File();
            _activityCount = new List<ActivityInformation>();
            _name = name;
            _description = description;
            LoadFromFile();
        }

        public string DisplayStartMessage()
        {
            string message = $"Welcome to the {_name} Activity.\n\n";
            message += $"{_description}\n\n";
            message += $"How long, in seconds, would you like for your session? ";
            return message;
        }

        public string DisplayEndMessage()
        {
            string message = $"You have completed another {_duration} seconds of the {_name} Activity.\n";
            return message;
        }

        public string DisplayReadyMessage() => $"Get ready...";

        public string DisplayWellDoneMessage() => "Well done !!";

        public void SetDuration(int duration) => _duration = duration;

        public int GetDuration() => _duration;

        public void SaveActivity(string name)
        {
            ActivityInformation activity = _activityCount.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            
            if (activity == null)
            {
                activity = new ActivityInformation { Name = name, Count = 1};
                _activityCount.Add(activity);
            }
            else
            {
                activity.Count += 1;
            }

            SaveToFile();        
        }

        public List<ActivityInformation> ShowNumberOfActivities() => _activityCount;

        public void ReverseTimer(int seconds)
        {
            for(int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void Spinner()
        {
            List<string> animationCharacters = new List<string>();
            animationCharacters.Add("|");
            animationCharacters.Add("/");
            animationCharacters.Add("-");
            animationCharacters.Add("\\");
            animationCharacters.Add("|");
            animationCharacters.Add("/");
            animationCharacters.Add("-");
            animationCharacters.Add("\\");

            foreach(string animationCharacter in animationCharacters)
            {
                Console.Write(animationCharacter);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }   
        }

        private void SaveToFile() => _file.SaveToFile(FILENAME, _activityCount);

        private void LoadFromFile() => _activityCount = _file.LoadFromFile(FILENAME);
    }
}