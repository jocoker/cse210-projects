 public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name)
        {
            Points = points;
        }

        public override void RecordEvent()
        {
            IsComplete = true;
            Console.WriteLine($"You completed the goal: {Name} and earned {Points} points!");
        }

        public override string DisplayStatus()
        {
            return IsComplete ? $"[X] {Name} (Points: {Points})" : $"[ ] {Name}";
        }
    }