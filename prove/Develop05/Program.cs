using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": CreateNewGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }
        }
        Console.WriteLine("Goodbye!");

    }

    static void CreateNewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which goal would you like to do?");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter a goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter a point value: ");
        int pts = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            // Switch to choose an option and return values to constuctor 
            case "1":
                goals.Add(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("Enter a target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter a bonus point amount: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
                break;
            default:
                Console.WriteLine("Not a valid option. Please try again.");
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("Your goals: ");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatusLine()}");
        }
        

    }

    static void RecordEvent()
    {
        Console.WriteLine("What goal did you accomplish?");
        ListGoals();
        Console.Write("Enter the goal number: ");

        // validate the input and convert into an idex
        if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= goals.Count)
        {
            // get the chosen goal
            int earned = goals[idx - 1].RecordEvent();
            totalPoints += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    static void SaveGoals()
    {

    }

    static void LoadGoals()
    {

    }

    


}