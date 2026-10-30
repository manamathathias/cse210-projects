using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade percentage? ");
        string input = Console.ReadLine();
        int gradepercentage = int.Parse(input);
        string letterGrade = "";
        if (gradepercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradepercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradepercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradepercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}");
        if (gradepercentage >= 60)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}