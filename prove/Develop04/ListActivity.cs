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

        public ListActivity()
        {
            _prompts = new List<string>();
            _responses = new List<string>();
            PopulatePrompts();
        }

        public void AddActivity()
        {
            _description = $"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _name = "Listing";

            Console.Write(DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(DisplayReadyMessage());
            Spinner();
            Console.WriteLine();

            Console.WriteLine("List as many responses you can to get the following prompt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
            Console.Write($"You may begin in: ");
            ReverseTimer(5);

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));
            Console.Clear();

            while (endTime > DateTime.Now)
            {
                Console.Write($"> ");
                string response = Console.ReadLine();
                SaveResponse(response);
            }
            SaveActivity(_name);

            Console.WriteLine();
            Console.WriteLine($"You listed {GetCountResponse()} items !\n");
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

        private void SaveResponse(string response)
        {
            _responses.Add(response);
        }

        private int GetCountResponse()
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