public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public void Display()
    {
        Console.Write($"Date: {Date}, ");
        Console.Write($"Prompt: {PromptText}: ");
        Console.WriteLine($"Entry: {EntryText}");
    }
}