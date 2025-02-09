class Breathing : Activity
{
    public Breathing()
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start(int duration)
    {
        StartMessage(duration);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            PauseAnimation(4);
            Console.WriteLine("Breathe out...");
            PauseAnimation(4);
        }
        EndMessage(duration);
    }
}
