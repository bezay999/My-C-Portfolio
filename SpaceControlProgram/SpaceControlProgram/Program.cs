using System;
namespace SpaceControlProgram;

class Program
{
    static void Main(string[] args)
    {
        MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
        MoonRover apollo = new MoonRover("Apollo 15", 1971);
        MarsRover sojourner = new MarsRover("Sojourner", 1997);
        Satellite sputnik = new Satellite("Sputnik", 1957);

        Rover[] rovers = { lunokhod, apollo, sojourner };
        
        DirectAll(rovers);
        
        Object [] probes = {lunokhod, apollo, sojourner, sputnik};
        foreach (Object x in probes)
        {
            Console.WriteLine();
            Console.WriteLine(x.GetType());
        }
        
        
    }
   
    static void DirectAll(Rover[] rovers)
    {
        foreach (var rover in rovers)
        {
            Console.WriteLine(rover.GetInfo());
            Console.WriteLine(rover.Explore());
            Console.WriteLine(rover.Collect());
        }
    }
}