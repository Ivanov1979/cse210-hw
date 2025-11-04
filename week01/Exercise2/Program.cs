using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage:");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        string letter;

        if (percent >= 90)
            letter = "A";
        else if (percent >= 80)
            letter = "B";
        else if (percent >= 70)
            letter = "C";
        else if (percent >= 60)
            letter = "D";
        else
            letter = "F";
            
         Console.WriteLine($"Your letter grade is: {letter}");

        if (percent >= 70)
            Console.WriteLine(" Congratulations! you passed the course.");

        else Console.WriteLine("Keep trying - You can improve next time!");
    }
}   
        