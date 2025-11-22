using System;

namespace BiblioInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource r = new Resource("Harry Potter", "Story");
            r.GetInfo();
            Book b = new Book("Sherlok Holmes", "Detective", "Arthur", 400);
            b.GetInfo();
            Periodical p = new Periodical("Wierd", "Drama", "Monthly");
            p.UpdateStatus();
            p.GetInfo();
            Video v = new Video("Interstellar", "Sci-Fi", "Nolan", 120, "movie");
            v.UpdateStatus();
            v.GetInfo();
        }
    }
}