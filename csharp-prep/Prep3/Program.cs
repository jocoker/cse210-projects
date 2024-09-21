using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess My Number game!");

        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int magicNumbers = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int magicNumbers = randomGenerator.Next(1,100);

        int guess = -1;        
        
        while (guess != magicNumbers)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumbers > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumbers < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        }          

    }
}