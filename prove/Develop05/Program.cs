using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class Program
    {
        static void Main()
        {
            Activity[] activities = {
                new BreathingActivity(),
                new ReflectionActivity(),
                new ListingActivity()
            };

            while (true)
            {
                Console.WriteLine("\nChoose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
                {
                    if (choice == 4)
                    {
                        Console.WriteLine("Thank you for participating!");
                        break;
                    }
                    activities[choice - 1].StartActivity();
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }