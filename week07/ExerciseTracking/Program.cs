namespace ExerciseTracking;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of base type Activity → polymorphism
        List<Activity> activities = new List<Activity>();

        // At least one of each
        activities.Add(new Running("03 Nov 2022", 30, 4.8));   // 4.8 km in 30 min
        activities.Add(new Cycling("04 Nov 2022", 45, 20.0));  // 20 kph for 45 min
        activities.Add(new Swimming("05 Nov 2022", 25, 40));   // 40 laps

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
