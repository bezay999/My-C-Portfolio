namespace SpaceControlProgram;

class Rover : Probe,  IDirectable 
{
    public string Alias
    { get; private set; }

    public int YearLanded
    { get; private set; }

    public Rover(string alias, int yearLanded) : base(alias,  yearLanded)
    {
        Alias = alias;
        YearLanded = yearLanded;
    }

    public string GetInfo()
    {
        return $"Alias: {Alias}, YearLanded: {YearLanded}";
    }

    public  string Explore()
    {
        return "Rover is exploring the surface!";
    }

    public string Collect()
    {
        return "Rover is collecting rocks!";
    }
}