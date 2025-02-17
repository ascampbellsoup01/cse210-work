using System;
namespace EternalQuest
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static int totalScore = 0;

        static void Main(string[] args)
        {
            // Add sample goals
            goals.Add(new SimpleGoal("Run a marathon", 1000));
            goals.Add(new EternalGoal("Read scriptures", 100));
            goals.Add(new ChecklistGoal("Attend temple", 50, 10, 500));

            // User interaction loop
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Create new goal\n2. Record goal event\n3. Show goals\n4. Show score\n5. Save goals\n6. Load goals\n7. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        RecordGoalEvent();
                        break;
                    case 3:
                        ShowGoals();
                        break;
                    case 4:
                        ShowScore();
                        break;
                    case 5:
                        SaveGoals();
                        break;
                    case 6:
                        LoadGoals();
                        break;
                    case 7:
                        exit = true;
                        break;
                }
            }
        }

        static void CreateNewGoal()
        {
            Console.WriteLine("Choose goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    goals.Add(new SimpleGoal(name, points));
                    break;
                case 2:
                    goals.Add(new EternalGoal(name, points));
                    break;
                case 3:
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());

                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                    break;
            }
        }

        static void RecordGoalEvent()
        {
            Console.WriteLine("Choose goal to record:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].Points;
        }

        static void ShowGoals()
        {
            foreach (var goal in goals)
            {
                string status = goal.IsCompleted ? "[X]" : "[ ]";
                if (goal is ChecklistGoal checklistGoal)
                {
                    status += $" (Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times)";
                }
                Console.WriteLine($"{status} {goal.Name}");
            }
        }

        static void ShowScore()
        {
            Console.WriteLine($"Total Score: {totalScore} points");
        }

        static void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(totalScore);
                foreach (var goal in goals)
                {
                    string goalData = $"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.IsCompleted}";
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        goalData += $",{checklistGoal.TargetCount},{checklistGoal.CurrentCount},{checklistGoal.BonusPoints}";
                    }
                    writer.WriteLine(goalData);
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        static void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    totalScore = int.Parse(reader.ReadLine());
                    goals.Clear();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        string type = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isCompleted = bool.Parse(parts[3]);

                        if (type == "SimpleGoal")
                        {
                            goals.Add(new SimpleGoal(name, points) { IsCompleted = isCompleted });
                        }
                        else if (type == "EternalGoal")
                        {
                            goals.Add(new EternalGoal(name, points) { IsCompleted = isCompleted });
                        }
                        else if (type == "ChecklistGoal")
                        {
                            int targetCount = int.Parse(parts[4]);
                            int currentCount = int.Parse(parts[5]);
                            int bonusPoints = int.Parse(parts[6]);
                            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints)
                            {
                                IsCompleted = isCompleted,
                                CurrentCount = currentCount
                            });
                        }
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
    }
}
