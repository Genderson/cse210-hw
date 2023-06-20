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
        string option = string.Empty;
        Console.Clear();

        while (option != "5")
        {
            
            Console.WriteLine("Menu options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Show the number of activites done");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            //Console.Clear();

            if (option.Equals("1"))
            {
                var breatheActivity = new BreatheActivity();
                breatheActivity.AddActivity();
            }
            else if (option.Equals("2"))
            {
                var reflectActivity = new ReflectActivity();
                reflectActivity.AddActivity();
            }
            else if (option.Equals("3"))
            {
                var listActivity = new ListActivity();
                listActivity.AddActivity();
            }
            else if (option.Equals("4"))
            {
                Console.Clear();
                var activity = new Activity();
                List<ActivityInformation> listActivity = activity.ShowNumberOfActivities();

                if (listActivity.Count > 0)
                {
                    foreach (var item in listActivity)
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
            else if (option.Equals("5"))
            {
                Console.WriteLine("have a good day !!!\n");
            }
        }
    }
}