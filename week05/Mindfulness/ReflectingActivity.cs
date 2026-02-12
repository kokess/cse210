using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity()
        : base(
              "Reflecting",
              "This activity helps you reflect on strength and resilience."
              )
    {
        _prompts = new List<string>
        {
            "Think of a time when you helped someone.",
            "Think of a time when you did something difficult.",
            "Think of a time when you showed courage.",
            "Think of a time when you overcame fear."
        };

        _questions = new List<string>
        {
            "Why was this meaningful?",
            "How did you feel?",
            "What did you learn?",
            "How can you apply this again?",
            "What made you successful?"
        };
    }

    protected override void PerformActivity()
    {
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine(prompt);

        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];

            Console.WriteLine($"\n{question}");
            ShowSpinner(4);
        }
    }
}
