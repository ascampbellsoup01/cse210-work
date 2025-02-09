abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartMessage(int duration)
    {
        Console.WriteLine($"{Name} Activity\n{Description}\nDuration: {duration} seconds\nPrepare to begin...\n");
        PauseAnimation(3);
    }

    public void EndMessage(int duration)
    {
        Console.WriteLine($"Great job! You've completed the {Name} Activity for {duration} seconds.\n");
        PauseAnimation(3);
    }

    public void PauseAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");
        }
        Console.WriteLine();
    }

    public abstract void Start(int duration);
}
