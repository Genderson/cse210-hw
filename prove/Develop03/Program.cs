using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        string text = "Y después de haber ayunado cuarenta días y cuarenta noches, tuvo hambre.";
        Reference _reference = new Reference("Mateo", 4, 2);
        Scripture _scripture = new Scripture(text, _reference);

        string entry = string.Empty;
        int index = _scripture.GetCount() + 1;

        while(index > 0 && !entry.Equals("quit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear();

            var reference = _reference.DisplayReference();
            var textShow = _scripture.GetRenderedText();

            Console.WriteLine($"{reference} {textShow}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");    

            if(_scripture.IsAnyWordVisible())  
            {
                _scripture.HideWord();
            }      
               
            index--;
            entry = Console.ReadLine();
        }
    }
}