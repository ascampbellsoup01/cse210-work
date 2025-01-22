using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = promptGenerator.randomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    Date = DateTime.Now.ToString("yyyy-MM-dd"),
                    PromptText = prompt,
                    EntryText = response
                };
                journal.AddEntry(entry);
            }
            else if (option == "2")
            {
                journal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (option == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (option == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again.");
            }
        }
    }
}
