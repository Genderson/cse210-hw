using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class ListActivity : Activity
    {
        private readonly List<string> _prompts;
        private readonly List<string> _responses;

        public ListActivity(string name, string description) : base(name, description)
        {
            _prompts = new List<string>();
            _responses = new List<string>();
            PopulatePrompts();
        }

        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            int position  = rnd.Next(0, _prompts.Count);
            return _prompts[position];
        }

        public void SaveResponse(string response)
        {
            _responses.Add(response);
        }

        public int GetCountResponse()
        {
            return _responses.Count;
        }

        private void PopulatePrompts()
        {
            _prompts.AddRange(
                new[]{
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                });
        }

    }
}