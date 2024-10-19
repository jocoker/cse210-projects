using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Jordan C", "Programming Basics");
        Console.WriteLine(a1.GetSummary());

        
        MathAssignment a2 = new MathAssignment("John Smith", "Math", "10.1", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jane Doe", "Economics", "The Economics of World War I");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}