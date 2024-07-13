using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayPlayerInfo();
                    break;
                case "4":
                    ListGoalNames();
                    break;
                case "5":
                    ListGoalDetails();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Player Info");
        Console.WriteLine("4. List Goal Names");
        Console.WriteLine("5. List Goal Details");
        Console.WriteLine("6. Save Goals");
        Console.WriteLine("7. Load Goals");
        Console.WriteLine("8. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        Goal newGoal;
        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }
        _goals.Add(newGoal);
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    private void SaveGoals()
    {
        string json = JsonSerializer.Serialize(new { Score = _score, Goals = _goals });
        File.WriteAllText("goals.json", json);
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.json"))
        {
            string json = File.ReadAllText("goals.json");
            var data = JsonSerializer.Deserialize<SaveData>(json);
            _score = data.Score;
            _goals = data.Goals;
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}