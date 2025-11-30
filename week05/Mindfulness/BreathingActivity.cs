using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through slow breathing in and out.")
    {
    }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        End();
    }
}
