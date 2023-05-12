using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class PromptGenerator
    {
        private readonly List<string> _prompts = new List<string>();

        public PromptGenerator(){
            PopulatePromptList();
        }
        
        
        public string GetPrompt(){
            Random rnd = new Random();
            int position  = rnd.Next(0, _prompts.Count);
            return _prompts[position];
        }

        private void PopulatePromptList(){
            _prompts.AddRange(
                new[]{
                    "Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?",
                    "What things am I thankful for?",
                    "Today I had the opportunity to help someone?",
                    "What did I learn from my family today?"
                });                
        }
    }
}