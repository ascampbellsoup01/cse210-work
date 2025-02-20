using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running { Date = new DateTime(2022, 11, 3), Minutes = 30, Distance = 3.0 },
            new Cycling { Date = new DateTime(2022, 11, 4), Minutes = 45, Speed = 15 },
            new Swimming { Date = new DateTime(2022, 11, 5), Minutes = 20, Laps = 30 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
