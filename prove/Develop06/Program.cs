using System;


public class Program
    {
        private static List<Goal> goals = new List<Goal>();
        private static int totalPoints = 0;

        public static void Main(string[] args)
        {
            LoadGoals();

            while (true)
            {
                Console.WriteLine("\nEternal Quest Menu:");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Show goals");
                Console.WriteLine("4. Show total score");
                Console.WriteLine("5. Save goals");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

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
                        ShowGoals();
                        break;
                    case "4":
                        ShowScore();
                        break;
                    case "5":
                        SaveGoals();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void CreateGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Choose goal type:\n1. Simple\n2. Eternal\n3. Checklist");
            string typeChoice = Console.ReadLine();

            switch (typeChoice)
            {
                case "1":
                    Console.Write("Enter points: ");
                    int simplePoints = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(name, simplePoints));
                    break;
                case "2":
                    Console.Write("Enter points per event: ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(name, eternalPoints));
                    break;
                case "3":
                    Console.Write("Enter number of required events: ");
                    int requiredCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter points per event: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, requiredCount, checklistPoints, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void RecordEvent()
        {
            Console.WriteLine("Select a goal to record an event:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
            }

            if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= goals.Count)
            {
                Goal goal = goals[goalIndex - 1];
                goal.RecordEvent();

                // Update points
                if (goal.IsComplete)
                {
                    totalPoints += goal.Points;
                }
                else if (goal is EternalGoal)
                {
                    totalPoints += goal.Points;
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    totalPoints += checklistGoal.Points;
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        private static void ShowGoals()
        {
            Console.WriteLine("\nGoals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.DisplayStatus());
            }
        }

        private static void ShowScore()
        {
            Console.WriteLine($"Total Score: {totalPoints} points");
        }

        private static void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in goals)
                {
                    string line = $"{goal.GetType().Name}|{goal.Name}|{goal.Points}|{(goal.IsComplete ? "X" : " ")}";
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        var checklistGoalData = $"{checklistGoal.CurrentCount}|{checklistGoal.RequiredCount}|{checklistGoal.BonusPoints}";
                        line += "|" + checklistGoalData;
                    }
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Goals saved.");
        }

        private static void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                goals.Clear(); // Clear existing goals
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        string goalType = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = parts[3] == "X";
                        

                        if (goalType == nameof(SimpleGoal))
                        {
                            goals.Add(new SimpleGoal(name, points) { IsComplete = isComplete });
                        }
                        else if (goalType == nameof(EternalGoal))
                        {
                            goals.Add(new EternalGoal(name, points) { IsComplete = isComplete });
                        }
                        else if (goalType == nameof(ChecklistGoal))
                        {
                            int currentCount = int.Parse(parts[4]);
                            int requiredCount = int.Parse(parts[5]);
                            int bonusPoints = int.Parse(parts[6]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, requiredCount, points, bonusPoints)
                            {
                                IsComplete = isComplete,
                                CurrentCount = currentCount
                            };
                            goals.Add(checklistGoal);
                        }
                    }
                }
            }
        }
    }