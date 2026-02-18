using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    /*Adding Creativity*/
    /*Every 1000 points = new level.*/
    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nYour Score: {_score}");
            Console.WriteLine($"Level: {GetLevel()}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Progress Goal");
        Console.Write("Select type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));

        else if (type == "3")
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else if (type == "4")
        {
            Console.Write("Target Amount: ");
            int target = int.Parse(Console.ReadLine());

            _goals.Add(new ProgressGoal(name, desc, points, target));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();

        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");

        int previousLevel = GetLevel();
        _score += earned;
        int newLevel = GetLevel();

        if (newLevel > previousLevel)
        {
            Console.WriteLine("🎉 LEVEL UP! You reached Level " + newLevel);
        }

    }


    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
            return;

        string[] lines = File.ReadAllLines("goals.txt");

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }

            else if (type == "EternalGoal")
            {
                var goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }

            else if (type == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(
                    parts[1],                  // for name
                    "",                        // for the description (optional if not stored)
                    int.Parse(parts[2]),       // for points
                    int.Parse(parts[3]),       // for target
                    int.Parse(parts[4])        // if bonus
                );

                _goals.Add(goal);
            }

            else if (type == "ProgressGoal")
            {
                var goal = new ProgressGoal(
                    parts[1],
                    "",
                    int.Parse(parts[2]),
                    int.Parse(parts[3])
                );

                _goals.Add(goal);
            }

            else if (type == "NegativeGoal")
            {
                var goal = new NegativeGoal(
                    parts[1],
                    "",
                    int.Parse(parts[2])
                );

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

}
