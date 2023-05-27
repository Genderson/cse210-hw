using Develop03;

/*
EXCEED CORE REQUIREMENTS
I added a menu with two option:
1. I added the possibility that the user define his/her own scripture
2. I added a library of scriptures. The scripture is choose randomly 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer program");
        Console.WriteLine();
        Console.WriteLine("What do you want to do:");
        Console.WriteLine("1) Press 1 if you want to type your own scripture");
        Console.WriteLine("2) Press 2 if you want to get a random scripture");

        string option = Console.ReadLine();
        Scripture scripture = new Scripture();

        switch(option)
        {
            case "1":
                Console.Write("Enter the scripture text: ");
                string text = Console.ReadLine();

                Console.Write("Enter the book: ");
                string book = Console.ReadLine();

                Console.Write("Enter the chapter: ");
                int chapter = int.Parse(Console.ReadLine());

                Console.Write("Enter the start verse: ");
                int verse = int.Parse(Console.ReadLine());

                Console.Write("Is more than one verse (yes/no)?: ");
                string answer = Console.ReadLine();

                int endVerse = 0;
                if(answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter the end verse: ");
                    endVerse = int.Parse(Console.ReadLine());
                    scripture = new Scripture(text, new Reference(book, chapter, verse, endVerse));
                }
                else
                {
                    scripture = new Scripture(text, new Reference(book, chapter, verse));
                }

                DisplayScripture(scripture);
                break;

            case "2":
                scripture = GetScriptures();
                DisplayScripture(scripture);
                break;
        }
    }

    private static void DisplayScripture(Scripture scripture)
    {
        string entry = string.Empty;
        int index = scripture.GetCount() + 1;

        while(index > 0 && !entry.Equals("quit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear();

            var reference = scripture.GetReference().DisplayReference();
            var textShow = scripture.GetRenderedText();

            Console.WriteLine($"{reference} {textShow}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");    

            if(scripture.IsAnyWordVisible())  
            {
                scripture.HideWord();
            }      
               
            index--;
            entry = Console.ReadLine();
        }
    }

    private static Scripture GetScriptures()
    {
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

        Random rnd = new Random();
        int position  = rnd.Next(0, scriptures.Count);
        
        return scriptures[0];
    }
}