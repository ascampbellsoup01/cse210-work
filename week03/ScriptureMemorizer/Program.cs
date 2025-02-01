using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}