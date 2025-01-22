public class Prompt
{
    public List<string> _prompts;

    public Prompt()
    {
        _prompts = new List<string>
        {
            "What did you learn today?",
            "What made you smile today?",
            "What are you grateful for?"
        };
    }

    public string randomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}