using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcometomyprogrammeplan();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
        Console.WriteLine($"Thank you for using the program, {userName}!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static void DisplayWelcometomyprogrammeplan()
    {
        Console.WriteLine("Welcome to my Program plan!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please what is your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}