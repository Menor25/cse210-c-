using System;

// I added a mood tracker to the journal entry
// This will help the user to track are they felt during the entry
// I added "prompt" and "response" for clarity when the file is read
// I added a PromptGenerator Method
// I used TryParse to prevent the program from cashing error 
// if the user input a text
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!.");

        bool isOpen = true;

        while (isOpen)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            int choice = 0;

            int.TryParse(input, out choice);

                    
            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today (Mood)? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response, mood);
                journal.AddEntry(newEntry);
            }else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                isOpen = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}