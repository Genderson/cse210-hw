using System;
using Develop04;

class Program
{
    /*
    Exceeding Requirements
    I added the functionality of store in a json file the activities done by the user
    Also, I added a new menu option to display the activities done by the user
    */
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Show the number of activites done");
        Console.WriteLine("  5. Quit");
        Console.Write("Select a choice from the menu: ");
        string option = Console.ReadLine();

        Console.Clear();

        if(option.Equals("1"))
        {
            string description = $"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
            string name = "Breathing";

            var breathing = new BreatheActivity(name, description);

            Console.Write(breathing.DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(breathing.DisplayReadyMessage());
            breathing.Spinner();
            Console.WriteLine();

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));

            while (endTime > DateTime.Now){
                Console.Write(breathing.DisplayBreatheInMessage());
                breathing.ReverseTimer(4);                
                Console.WriteLine();
                Console.Write(breathing.DisplayBreatheOutMessage());
                breathing.ReverseTimer(6);

                Console.WriteLine("\n");
            }
            breathing.SaveActivity(name);

            Console.WriteLine(breathing.DisplayWellDoneMessage());
            breathing.Spinner();
            Console.WriteLine("\n");

            breathing.SetDuration(int.Parse(duration));
            Console.Write(breathing.DisplayEndMessage());
            breathing.Spinner();
        }
        else if(option.Equals("2"))
        {
            string description = $"This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.";
            string name = "Reflecting";

            var reflect = new ReflectActivity(name, description);

            Console.Write(reflect.DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(reflect.DisplayReadyMessage());
            reflect.Spinner();
            Console.WriteLine();

            Console.WriteLine("Consider the following promt:\n");
            Console.WriteLine($"--- {reflect.GetRandomPrompt()} ---\n");
            Console.WriteLine($"When you have something in mind, press enter to continue");
            Console.ReadLine();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience");
            Console.Write($"You may begin in: ");
            reflect.ReverseTimer(5);

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));
            Console.Clear();

            while (endTime > DateTime.Now)
            {
                string question = reflect.GetRandomQuestion();
                Console.Write($"> {question} ");
                reflect.Spinner();
                Console.WriteLine();
            }            
            reflect.SaveActivity(name);

            Console.WriteLine();
            Console.WriteLine(reflect.DisplayWellDoneMessage());
            reflect.Spinner();
            Console.WriteLine("\n");

            reflect.SetDuration(int.Parse(duration));
            Console.Write(reflect.DisplayEndMessage());
            reflect.Spinner();
        }
        else if(option.Equals("3"))
        {
            string description = $"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            string name = "Listing";

            var listActivity = new ListActivity(name, description);

            Console.Write(listActivity.DisplayStartMessage());
            string duration = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(listActivity.DisplayReadyMessage());
            listActivity.Spinner();
            Console.WriteLine();

            Console.WriteLine("List as many responses you can to get the following prompt:\n");
            Console.WriteLine($"--- {listActivity.GetRandomPrompt()} ---\n");
            Console.Write($"You may begin in: ");
            listActivity.ReverseTimer(5);

            DateTime endTime = DateTime.Now.AddSeconds(double.Parse(duration));
            Console.Clear();

            while (endTime > DateTime.Now)
            {
                Console.Write($"> ");
                string response = Console.ReadLine();
                listActivity.SaveResponse(response);
            }
            listActivity.SaveActivity(name);

            Console.WriteLine();
            Console.WriteLine($"You listed {listActivity.GetCountResponse()} items !\n");
            Console.WriteLine(listActivity.DisplayWellDoneMessage());
            listActivity.Spinner();
            Console.WriteLine("\n");

            listActivity.SetDuration(int.Parse(duration));
            Console.Write(listActivity.DisplayEndMessage());
            listActivity.Spinner();
        }
        else if(option.Equals("4"))
        {
            var activity = new Activity();
            List<ActivityInformation> listActivity = activity.ShowNumberOfActivities();

            if(listActivity.Count > 0)
            {
                foreach(var item in listActivity)
                {
                    Console.WriteLine($"Activity: {item.Name} - Count: {item.Count}");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no records in the list \n");
            }
        }
        else if(option.Equals("5"))
        {
            Console.WriteLine("have a good day !!!\n");
        }
    }
}