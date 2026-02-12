using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;
    private Random _random = new Random();

    public ListingActivity()
        : base(
              "Listing",
              "This activity helps you list positive things in your life."
              )
    {
        _prompts = new List<string>
        {
            "Who do you appreciate?",
            "What are your strengths?",
            "Who did you help recently?",
            "Who inspires you?"
        };

        _items = new List<string>();
    }

    protected override void PerformActivity()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");

        Console.WriteLine("\nStart listing items...");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            _items.Add(item);
        }

        Console.WriteLine($"\nYou listed {_items.Count} items!");
    }
}
