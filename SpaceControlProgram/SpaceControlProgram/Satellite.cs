namespace SpaceControlProgram;

class Satellite : Probe,  IDirectable
{
    public string Alias
    { get; private set; }

    public int YearLaunched
    { get; private set; }

    public Satellite(string alias, int yearLanded) : base(alias, yearLanded)
    {
        Alias = alias;
        YearLaunched = yearLanded;
    }

    public string GetInfo()
    {
        return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
    }

    public string Explore()
    {
        return "Satellite is exploring the far reaches of space!";
    }

    public string Collect()
    {
        return "Satellite is collecting photographic evidence!";
    }
}