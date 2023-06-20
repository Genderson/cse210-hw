using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class BreatheActivity : Activity
    {
        public void AddActivity()
        {
            _description = $"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
            _name = "Breathing";

            Console.Write(DisplayStartMessage());

            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(DisplayReadyMessage());
            Spinner();
            Console.WriteLine();

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));

            while (endTime > DateTime.Now){
                Console.Write(DisplayBreatheInMessage());
                ReverseTimer(4);                
                Console.WriteLine();
                Console.Write(DisplayBreatheOutMessage());
                ReverseTimer(6);

                Console.WriteLine("\n");
            }
            SaveActivity(_name);

            Console.WriteLine(DisplayWellDoneMessage());
            Spinner();
            Console.WriteLine("\n");

            SetDuration(int.Parse(duration));
            Console.Write(DisplayEndMessage());
            Spinner();
            Console.Clear();
        }

        private string DisplayBreatheInMessage() => "Breathe in ...";

        private string DisplayBreatheOutMessage() => "Now Breathe out ...";
    }
}