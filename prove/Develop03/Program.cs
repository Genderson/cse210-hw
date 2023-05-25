using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string text = "Y después de haber ayunado cuarenta días y cuarenta noches, tuvo hambre.";
        Reference _reference = new Reference("Mateo", 4, 2);
        Scripture _scripture = new Scripture(text, _reference);

        var reference = _reference.DisplayReference();
        var textShow = _scripture.GetRenderedText();
        Console.WriteLine($"{reference} {textShow}");

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.ReadLine();

        int count = 0;
        while(count < 7){
            count++;
            Console.Clear();

            _scripture.HideWord();

            reference = _reference.DisplayReference();
            textShow = _scripture.GetRenderedText();
            Console.WriteLine($"{reference} {textShow}");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.ReadLine();
        }
    }
}