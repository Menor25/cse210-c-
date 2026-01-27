// I created a library of scriptures.
// The program randomly selects one to present to the user.
using System;

class Program
{
    static void Main(string[] args)
    { 
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(
            new Reference("John", 3, 16), 
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        ));

        library.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all this through him who gives me strength."
        ));

        Random random = new Random();
        int index = random.Next(library.Count);
        Scripture scripture = library[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Hide 3 random words each time
            scripture.HideRandomWords(3);
        }
    }
}