using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();

       string userName = PromptUserName();
       int userNumber = PromptUserNumber();
       int squaredNumber = SquareNumber(userNumber);

       DisplayResult(userName, squaredNumber);       
        
    }    
        
        
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
        
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        int number;
        Console.Write("What is your favorite number? ");
        number = int.Parse(Console.ReadLine());
        return number;                    
    }

    static int SquareNumber(int usersNumber)
    {
        int squareNumbers; 
        squareNumbers = (usersNumber * usersNumber);
        return squareNumbers;
    }

    static void DisplayResult(string name, int squareNumbers)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumbers}.");
    }
        
    
}