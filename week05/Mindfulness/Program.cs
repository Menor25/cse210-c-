using System;
// I have added a static dictionary to keep a log of how many times 
// each activity was performed during this session.
class Program
{
    static Dictionary<string, int> _activityLog = new Dictionary<string, int>
    {
        { "Breathing", 0 },
        { "Reflection", 0 },
        { "Listing", 0 }
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View Session Log (Extra Feature)");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                _activityLog["Breathing"]++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                _activityLog["Reflection"]++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                _activityLog["Listing"]++;
            }
            else if (choice == "4")
            {
                DisplayLog();
            }
            else if (choice == "5")
            {
                break;
            }
        }
        
        static void DisplayLog()
        {
            Console.Clear();
            Console.WriteLine("Session Log:");
            foreach (var entry in _activityLog)
            {
                Console.WriteLine($"{entry.Key} Activity: Completed {entry.Value} times.");
            }
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }
    
    }
}