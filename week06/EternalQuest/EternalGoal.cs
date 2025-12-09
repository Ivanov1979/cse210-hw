using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            Console.WriteLine($"Recorded \"{Name}\" and earned {Points} points.");
            return Points;
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDisplayString()
        {
            return $"[ ] {Name} ({Description}) (Eternal)";
        }

        public override string Serialize()
        {
            return $"EternalGoal|{Name}|{Description}|{Points}";
        }

        public static EternalGoal FromSerialized(string[] parts)
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            return new EternalGoal(name, description, points);
        }
    }
}
