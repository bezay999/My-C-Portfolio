namespace BiblioInheritance;

public class Periodical : Resource
{
    public string Period
    {
        get;
        set;
    }
    
    public Periodical(string title, string category, string period )  : base(title, category)
    {
        Period = period;
    }
    
    public override void UpdateStatus()
    {
        newStatus = "In-Use";
        base.UpdateStatus();
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Period: {Period}");
    }
}