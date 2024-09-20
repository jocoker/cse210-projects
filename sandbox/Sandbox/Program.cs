using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#.");

        Console.Write("What is your fav color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"I like the color {color} too!");
    }
}