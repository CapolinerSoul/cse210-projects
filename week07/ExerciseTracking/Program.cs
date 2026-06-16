using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
// Create a list of Activity (base class)
        List<Activity> activities = new List<Activity>();

        // Add different activity types
        activities.Add(new Running(5.0, 30));     // 5 km in 30 min
        activities.Add(new Cycling(20.0, 45));    // 20 kph for 45 min
        activities.Add(new Swimming(20, 30));     // 20 laps in 30 min

        // Loop through and print summaries
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }

    }
}