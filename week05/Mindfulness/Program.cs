using System;

class Program
{
    static int _totalActivitiesCompleted = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                activity = new ReflectingActivity();
            }
            else if (choice == "3")
            {
                activity = new ListingActivity();
            }
            else if (choice == "4")
            {
                break;
            }

            if (activity != null)
            {
                activity.Run();
                _totalActivitiesCompleted++;

                Console.WriteLine($"\nTotal activities completed this session: {_totalActivitiesCompleted}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}

/*
CREATIVITY EXCEEDED REQUIREMENTS:
This program tracks and displays the total number of mindfulness activities
completed during the session. This helps motivate users and provides progress feedback.
*/
