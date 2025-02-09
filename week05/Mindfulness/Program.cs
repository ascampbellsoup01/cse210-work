using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Activity> activities = new Dictionary<string, Activity>
        {
            { "1", new Breathing() },
            { "2", new Reflection() },
            { "3", new Listing() }
        };

        while (true)
        {
            Console.WriteLine("\nMindfulness App\n1. Breathing\n2. Reflection\n3. Listing\n4. Exit");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (activities.TryGetValue(choice, out Activity activity))
            {
                Console.Write("Enter duration in seconds: ");
                if (int.TryParse(Console.ReadLine(), out int duration))
                {
                    activity.Start(duration);
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
