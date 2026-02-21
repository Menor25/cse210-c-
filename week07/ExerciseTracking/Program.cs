using System;

class Program
{
    static void Main(string[] args)
    {
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 20, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        Console.WriteLine("Fitness Center Activity Summaries:");
        
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}