using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Console.Write("How was your mood today (1–5)? ");
                    string mood = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, response, mood);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

/*
EXCEEDS REQUIREMENTS:
1. Each entry stores a daily mood rating (1–5).
2. File format designed so it can easily be converted to JSON later.
*/
