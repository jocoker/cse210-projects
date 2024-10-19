abstract class Activity
    {
        protected string Name { get; }
        protected string Description { get; }
        
        protected Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void StartActivity()
        {
            Console.WriteLine($"\nStarting the '{Name}' activity!");
            Console.WriteLine(Description);
            int duration = GetDuration();
            Console.WriteLine("Prepare to begin...");
            PauseWithSpinner(3); // Pause for 3 seconds
            ExecuteActivity(duration);
            FinishActivity(duration);
        }

        protected abstract void ExecuteActivity(int duration);

        protected void FinishActivity(int duration)
        {
            Console.WriteLine("Good job! You have completed the activity.");
            PauseWithSpinner(3); // Pause for 3 seconds
            Console.WriteLine($"You completed the '{Name}' activity for {duration} seconds.");
        }

        protected int GetDuration()
        {
            Console.Write("Enter the duration of the activity in seconds: ");
            return int.Parse(Console.ReadLine());
        }

        protected void PauseWithSpinner(int seconds)
        {
            Console.Write("Loading");
            for (int i = 0; i < seconds; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".", i + 1);
            }
            Console.WriteLine();
        }
    }