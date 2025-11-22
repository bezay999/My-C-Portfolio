namespace BiblioInheritance;

public class Video : Resource
{
    public string Director { get; set; }
    public int RunTime { get; set; }
    
    public Video(string title, string category, string director, int runTime, string mediaType)   : base(title, category)
    {
        Director = director;
        RunTime = runTime;
    }
    
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Run time: {RunTime}");
    }

    public override void UpdateStatus()
    {
        newStatus = "On-Demand";
        base.UpdateStatus();
    }
}