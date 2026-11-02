using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomguess = new Random();
        int magicnumber = randomguess.Next(1, 2026);
        int guessnumber = -1;
        int guesscount = 0;

        while (guessnumber != magicnumber)
        {
            Console.Write("What is your guess number? ");
            guessnumber = int.Parse(Console.ReadLine());
            guesscount++;

            if (guessnumber < magicnumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessnumber > magicnumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Your guess is correct!");
            }
        }

        Console.WriteLine($"It took you {guesscount} guesses.");
    }
}