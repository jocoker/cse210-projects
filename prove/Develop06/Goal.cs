 public abstract class Goal
    {
        public string Name { get; private set; }
        public int Points { get; protected set; }
        public bool IsComplete { get; set; }

        protected Goal(string name)
        {
            Name = name;
            IsComplete = false;
        }

        public abstract void RecordEvent();
        public abstract string DisplayStatus();
    }