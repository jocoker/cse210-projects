public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 08, 18), 20, 2.0), 
            new Cycling(new DateTime(2024, 08, 19), 45, 15.0), 
            new Swimming(new DateTime(2024, 08, 20), 30, 20) 
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}