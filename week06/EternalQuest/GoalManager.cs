using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("=== Eternal Quest ===");
                Console.WriteLine($"Points: {_score}");
                Console.WriteLine();
                Console.WriteLine("1. Display Score");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Create New Goal");
                Console.WriteLine("4. Record Event");
                Console.WriteLine("5. Save Goals");
                Console.WriteLine("6. Load Goals");
                Console.WriteLine("7. Quit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine($"Score: {_score}");
                        break;
                    case "2":
                        ListGoals();
                        break;
                    case "3":
                        CreateGoal();
                        break;
                    case "4":
                        RecordEvent();
                        break;
                    case "5":
                        SaveGoals();
                        break;
                    case "6":
                        LoadGoals();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void ListGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created.");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (type == "2")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "3")
            {
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }
        }

        private void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
                return;
            }

            Console.WriteLine("Select goal:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].Name}");
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                int earned = _goals[index].RecordEvent();
                _score += earned;
            }
        }

        private void SaveGoals()
        {
            Console.Write("Filename: ");
            string file = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    writer.WriteLine(g.Serialize());
                }
            }

            Console.WriteLine("Saved.");
        }

        private void LoadGoals()
        {
            Console.Write("Filename: ");
            string file = Console.ReadLine();

            string[] lines = File.ReadAllLines(file);

            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');

                if (parts[0] == "SimpleGoal")
                    _goals.Add(SimpleGoal.FromSerialized(parts));
                else if (parts[0] == "EternalGoal")
                    _goals.Add(EternalGoal.FromSerialized(parts));
                else if (parts[0] == "ChecklistGoal")
                    _goals.Add(ChecklistGoal.FromSerialized(parts));
            }

            Console.WriteLine("Loaded.");
        }
    }
}
