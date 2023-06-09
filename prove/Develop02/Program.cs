using System;
using Develop02;

///EXCEDDING REQUIREMENTS
/*
I saved and loaded my document in a JSON format
Also, if the user types a wrong option number I notify about it, and give a chance to retry 
*/
class Program
{
    private static readonly Journal _journal = new Journal();
    private enum Actions{ Write = 1, Display, Load, Save, Quit }
    static void Main(string[] args)
       {
        Console.WriteLine("Welcome to the Journal Program!");

        int actionSelected = -1;

        while(actionSelected != (int)Actions.Quit){

            Console.WriteLine("\r\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            actionSelected = int.Parse(Console.ReadLine());

            switch(actionSelected){
                case (int)Actions.Write:
                    string prompt = _journal.GetPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    _journal.WriteNewEntry(prompt, response);
                break;

                case (int)Actions.Display:
                    string journalEntries = _journal.DisplayJournal();
                    Console.WriteLine(journalEntries);
                break;

                case (int)Actions.Load:
                    Console.WriteLine("What is the filename (please do not include the extesion)?");
                    string fileName = Console.ReadLine();
                    _journal.LoadFromFile(fileName);
                break;

                case (int)Actions.Save:
                    Console.WriteLine("What is the filename (please do not include the extesion)?");
                    string file = Console.ReadLine();
                    _journal.SaveToFile(file);
                break;

                case (int)Actions.Quit:
                actionSelected = (int)Actions.Quit;
                break;
                    
                default:
                    Console.WriteLine("Option unsupported. Please try again");
                break;
            }
        }
    }
}