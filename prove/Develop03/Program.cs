using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer program");
        Console.WriteLine("What do you want to do:");
        Console.WriteLine("1) Press 1 if you want to type your own scripture");
        Console.WriteLine("2) Press 2 if you want to get a random scripture"); 

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


    private List<Scripture> GetScriptures(){
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture("And now, I, Nephi, speak concerning the prophecies of which " + 
        "my father hath spoken, concerning Joseph, who was carried into Egypt.", new Reference("2 Nephi", 4, 1)));

        scriptures.Add(new Scripture("And saying, Lord, my servant lieth at home sick of the palsy, grievously tormented. " +
        "And Jesus saith unto him, I will come and heal him.", new Reference("Matthew", 8, 6, 7)));

        scriptures.Add(new Scripture("Are ye so foolish? having begun in the Spirit, are ye now made perfect by the flesh? " +
        "Have ye suffered so many things in vain? if it be yet in vain.", new Reference("Galatians", 3, 3, 4)));

        scriptures.Add(new Scripture("And it supposeth me that they have come up hither to hear " + 
        "the pleasing aword of God, yea, the word which healeth the wounded soul.", new Reference("Jacob", 2, 8)));

        scriptures.Add(new Scripture("The Father, because he was conceived by the power of God; and the Son, because " + 
        "of the flesh; thus becoming the Father and Son", new Reference("Mosiah", 15, 3)));

        return scriptures;
    }
}