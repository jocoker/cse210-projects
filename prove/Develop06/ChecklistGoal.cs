 public class ChecklistGoal : Goal
    {
        public int currentCount;
        private int requiredCount;
        private int bonusPoints;
        public int RequiredCount;
        public int BonusPoints;

        public ChecklistGoal(string name, int requiredCount, int points, int bonusPoints) : base(name)
        {
            this.requiredCount = requiredCount;
            RequiredCount = this.requiredCount;
            Points = points;
            this.bonusPoints = bonusPoints;
            BonusPoints = this.bonusPoints;
            currentCount = 0;
        }

        public int CurrentCount
        {
            get { return currentCount; }
            set { currentCount = value; }
        }

        public override void RecordEvent()
        {
            currentCount++;
            int totalPoints = Points;

            if (currentCount == requiredCount)
            {
                totalPoints += bonusPoints;
                IsComplete = true;
                Console.WriteLine($"Congratulations! You completed the goal: {Name} and earned {totalPoints} points!");
            }
            else
            {
                Console.WriteLine($"You recorded an event for: {Name} and earned {Points} points!");
            }
        }

        public override string DisplayStatus()
        {
            return IsComplete ? $"[X] {Name} (Completed {currentCount}/{requiredCount})" : $"[ ] {Name} (Completed {currentCount}/{requiredCount})";
        }
    }