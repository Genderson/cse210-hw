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

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string DisplayStartMessage(){
            string message = $"Welcome to the {_name} Activity.\n\n";
            message += $"{_description}\n\n";
            message += $"How long, in seconds, would you like for your session? ";
            return message;
        }

        public string DisplayEndMessage(){
            string message = $"You have completed another {_duration} seconds of the {_name} Activity.\n";
            return message;
        }

        public string DisplayReadyMessage() => $"Get ready...";

        public string DisplayWellDoneMessage() => "Well done !!";

        public void SetDuration(int duration) => _duration = duration;

        public int GetDuration() => _duration;

        public void PauseScreen(){

        }
    }
}