using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers until the user enters 0 (0 is NOT added)
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // ---------- Core Requirements ----------

        // 1. Sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        // 2. Average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 3. Maximum
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // ---------- Stretch Challenges ----------

        // 1. Smallest positive number
        int smallestPositive = 0;
        foreach (int n in numbers)
        {
            if (n > 0 && (smallestPositive == 0 || n < smallestPositive))
            {
                smallestPositive = n;
            }
        }
        if (smallestPositive != 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // 2. Sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}