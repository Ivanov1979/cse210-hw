using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points, bool isComplete = false)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                Console.WriteLine($"Completed \"{Name}\" and earned {Points} points.");
                return Points;
            }
            else
            {
                Console.WriteLine($"\"{Name}\" is already complete.");
                return 0;
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDisplayString()
        {
            string mark = _isComplete ? "[X]" : "[ ]";
            return $"{mark} {Name} ({Description})";
        }

        public override string Serialize()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
        }

        public static SimpleGoal FromSerialized(string[] parts)
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            return new SimpleGoal(name, description, points, isComplete);
        }
    }
}
