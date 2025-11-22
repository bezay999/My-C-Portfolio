namespace BiblioInheritance;

public class Resource
{
    public string Title { get; private set; }
    public string Category { get; private set; }
    public string Status { get; protected set; }
    
    public string newStatus = "Out";

    public Resource(string title, string category)
    {
        this.Title = title;
        this.Category = category;
        Status = "Available";
    }

    public virtual void UpdateStatus()
    {
        
        if (Status == "Available")
        {
            Status = newStatus;
        }
        else
        {
            Status = "Available";
        }
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Status: {Status}");
    }
}