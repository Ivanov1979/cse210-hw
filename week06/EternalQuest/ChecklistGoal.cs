using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;
        private int _bonusPoints;

        public ChecklistGoal(string name, string description, int points,
                             int targetCount, int bonusPoints, int currentCount = 0)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonusPoints = bonusPoints;
            _currentCount = currentCount;
        }

        public override int RecordEvent()
        {
            _currentCount++;
            int total = Points;

            if (_currentCount == _targetCount)
            {
                total += _bonusPoints;
                Console.WriteLine($"Completed \"{Name}\" {_targetCount} times and earned {total} points.");
            }
            else
            {
                Console.WriteLine($"Progress \"{Name}\" {_currentCount}/{_targetCount}. Earned {Points} points.");
            }

            return total;
        }

        public override bool IsComplete()
        {
            return _currentCount >= _targetCount;
        }

        public override string GetDisplayString()
        {
            string mark = IsComplete() ? "[X]" : "[ ]";
            return $"{mark} {Name} ({Description}) -- Completed {_currentCount}/{_targetCount} times";
        }

        public override string Serialize()
        {
            return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
        }

        public static ChecklistGoal FromSerialized(string[] parts)
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int bonus = int.Parse(parts[5]);
            int current = int.Parse(parts[6]);
            return new ChecklistGoal(name, description, points, target, bonus, current);
        }
    }
}
