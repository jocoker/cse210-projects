class ListingActivity : Activity
    {
        private readonly List<string> prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() 
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void ExecuteActivity(int duration)
        {
            Console.WriteLine(prompts[new Random().Next(prompts.Count)]);
            PauseWithSpinner(3); // Give time to think

            List<string> items = new();
            int endTime = Environment.TickCount + (duration * 1000);
            while (Environment.TickCount < endTime)
            {
                Console.Write("List an item (or type 'done' to finish): ");
                string item = Console.ReadLine();
                if (item.ToLower() == "done") break;
                items.Add(item);
            }
            Console.WriteLine($"You listed {items.Count} items.");
        }
    }