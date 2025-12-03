namespace CorporatePolymorphism;

public class Engineer : Employee
{
    public override void SubmitDailyReport()
    {
        Console.WriteLine("Engineer submits daily report.");
    }
    public override void Work()
    {
        Console.WriteLine("Engineer works on a project.");
    }
}