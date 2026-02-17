using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all activities (polymorphism)
        List<Activity> activities = new List<Activity>();

        // Create at least one of each activity type
        Running running1 = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Running running2 = new Running(new DateTime(2024, 2, 14), 45, 4.5);

        Cycling cycling1 = new Cycling(new DateTime(2024, 1, 20), 30, 10.0);
        Cycling cycling2 = new Cycling(new DateTime(2024, 2, 5), 60, 15.0);

        Swimming swimming1 = new Swimming(new DateTime(2024, 2, 10), 30, 20);
        Swimming swimming2 = new Swimming(new DateTime(2024, 2, 17), 45, 35);

        // Add all activities to the same list
        activities.Add(running1);
        activities.Add(running2);
        activities.Add(cycling1);
        activities.Add(cycling2);
        activities.Add(swimming1);
        activities.Add(swimming2);

        // Iterate through the list and call GetSummary on each activity
        Console.WriteLine("=== Exercise Activity Log ===\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("\n=== End of Activity Log ===");
    }
}