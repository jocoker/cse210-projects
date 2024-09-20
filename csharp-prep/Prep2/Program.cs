using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int grade = int.Parse(gradePercent);

         //Identify letter grade
        string letter = "";
       
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }


//the + or - added
        if(grade >=97 || grade <60)
        {
            Console.WriteLine($"You get an {letter}.");
        }
        else if(grade % 10 >=7)
        {
            Console.WriteLine($"You get a {letter}+");
        }
        else if (grade % 10 <3)
        {
            Console.WriteLine($"You get a {letter}-");
        }
        else
        {
            Console.WriteLine($"You get an {letter}");
        }
        

//Pass the class                

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have not passed the class. Try again next time.");
        }

       
    }
}