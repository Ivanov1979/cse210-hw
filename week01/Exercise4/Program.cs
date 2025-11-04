using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int n))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }
            if (n == 0) break;
            numbers.Add(n);
        }

        int sum = 0;
        foreach (int n in numbers) sum += n;

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        int largest = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int n in numbers) if (n > largest) largest = n;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = int.MaxValue;
        foreach (int n in numbers) if (n > 0 && n < smallestPositive) smallestPositive = n;
        if (smallestPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers) Console.WriteLine(n);
    }
}
