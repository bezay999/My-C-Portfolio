namespace BiblioInheritance;

public class Book : Resource
{
    public string Author { get; set; }
    public int Pages { get; set; }
    
    public Book(string title, string category, string author, int pages)  : base(title, category)
    {
        Author = author;
        Pages = pages;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Pages: {Pages}");
    }
}