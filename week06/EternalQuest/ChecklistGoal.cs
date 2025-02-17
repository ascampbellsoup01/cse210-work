namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        public int TargetCount { get; set; }
        public int CurrentCount { get; set; }
        public int BonusPoints { get; set; }

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
        {
            TargetCount = targetCount;
            CurrentCount = 0;
            BonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            CurrentCount++;
            Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");

            if (CurrentCount >= TargetCount)
            {
                IsCompleted = true;
                Console.WriteLine($"Goal '{Name}' completed! You earned an additional {BonusPoints} points.");
            }
        }
    }
}
