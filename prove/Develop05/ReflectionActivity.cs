 class ReflectionActivity : Activity
    {
        private readonly List<string> prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly List<string> questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity() 
            : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
        {
        }

        protected override void ExecuteActivity(int duration)
        {
            Console.WriteLine(prompts[new Random().Next(prompts.Count)]);
            PauseWithSpinner(5); // Give time to think
            int endTime = Environment.TickCount + (duration * 1000);
            while (Environment.TickCount < endTime)
            {
                string question = questions[new Random().Next(questions.Count)];
                Console.WriteLine(question);
                PauseWithSpinner(5); // Pause for 5 seconds
            }
        }
    }