using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string userName = UserName();
        int userNumber = UserNumber();
        int squareNumber = SquareNumber(userNumber);
        Result(userName, squareNumber);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int UserNumber()
    {
        Console.Write("What is your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}");
    }
}