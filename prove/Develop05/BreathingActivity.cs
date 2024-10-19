class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void ExecuteActivity(int duration)
        {
            int endTime = Environment.TickCount + (duration * 1000);
            while (Environment.TickCount < endTime)
            {
                Console.WriteLine("Breathe in...");
                PauseWithSpinner(4); // Breathe in for 4 seconds
                Console.WriteLine("Breathe out...");
                PauseWithSpinner(4); // Breathe out for 4 seconds
            }
        }
    }