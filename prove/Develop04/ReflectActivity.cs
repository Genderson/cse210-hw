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

        public ReflectActivity()
        {
            PopulatePrompts();
            PopulateQuestions();
        }

        public void AddActivity()
        {
            _description = $"This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.";
            _name = "Reflecting";

            Console.Write(DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(DisplayReadyMessage());
            Spinner();
            Console.WriteLine();

            Console.WriteLine("Consider the following promt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
            Console.WriteLine($"When you have something in mind, press enter to continue");
            Console.ReadLine();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience");
            Console.Write($"You may begin in: ");
            ReverseTimer(5);

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));
            Console.Clear();

            while (endTime > DateTime.Now)
            {
                string question = GetRandomQuestion();
                Console.Write($"> {question} ");
                Spinner();
                Console.WriteLine();
            } 

            SaveActivity(_name);

            Console.WriteLine();
            Console.WriteLine(DisplayWellDoneMessage());
            Spinner();
            Console.WriteLine("\n");

            SetDuration(int.Parse(duration));
            Console.Write(DisplayEndMessage());
            Spinner();
            Console.Clear();
        }

        private string GetRandomPrompt()
        {
            Random rnd = new Random();
            int position  = rnd.Next(0, _prompts.Count);
            return _prompts[position];
        }

        private string GetRandomQuestion()
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