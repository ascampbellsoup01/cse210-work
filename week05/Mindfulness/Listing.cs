using System;
using System.Collections.Generic;

class Listing : Activity
{
    private static readonly List<string> Prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> remainingPrompts;

    public Listing()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        remainingPrompts = new List<string>(Prompts);
    }

    private string GetRandomPrompt()
    {
        if (remainingPrompts.Count == 0)
        {
            remainingPrompts.AddRange(Prompts);
        }
        int index = new Random().Next(remainingPrompts.Count);
        string prompt = remainingPrompts[index];
        remainingPrompts.RemoveAt(index);
        return prompt;
    }

    public override void Start(int duration)
    {
        StartMessage(duration);
        Console.WriteLine(GetRandomPrompt());
        PauseAnimation(3);
        Console.WriteLine("Start listing items...");
        PauseAnimation(3);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                itemCount++;
            }
        }
        Console.WriteLine($"You listed {itemCount} items.");
        EndMessage(duration);
    }
}
