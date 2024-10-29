public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name)
        {
            Points = points;
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"You recorded an event for: {Name} and earned {Points} points!");
        }

        public override string DisplayStatus()
        {
            return $"[ ] {Name} (Points per event: {Points})";
        }
    }