using System;
using System.Collections.Generic;

class Reflection : Activity
{
    private static readonly List<string> Prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> remainingPrompts;
    private List<string> remainingQuestions;

    public Reflection()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        remainingPrompts = new List<string>(Prompts);
        remainingQuestions = new List<string>(Questions);
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

    private string GetRandomQuestion()
    {
        if (remainingQuestions.Count == 0)
        {
            remainingQuestions.AddRange(Questions);
        }
        int index = new Random().Next(remainingQuestions.Count);
        string question = remainingQuestions[index];
        remainingQuestions.RemoveAt(index);
        return question;
    }

    public override void Start(int duration)
    {
        StartMessage(duration);
        Console.WriteLine(GetRandomPrompt());
        PauseAnimation(5);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            PauseAnimation(10);
        }
        EndMessage(duration);
    }
}
