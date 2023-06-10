using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class ReflectActivity : Activity
    {
        private List<string> _prompts = new List<string>();
        private List<string> _questions = new List<string>();

        public ReflectActivity(string name, string description) : base(name, description)
        {
            PopulatePrompts();
            PopulateQuestions();
        }

        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            int position  = rnd.Next(0, _prompts.Count);
            return _prompts[position];
        }

        public string GetRandomQuestion()
        {
            Random rnd = new Random();
            int position  = rnd.Next(0, _questions.Count);
            return _questions[position];
        }

        private void PopulatePrompts()
        {
            _prompts.AddRange(
                new[]{
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                });
        }

        private void PopulateQuestions()
        {
            _questions.AddRange(
                new[]{
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                });
        }
    }
}