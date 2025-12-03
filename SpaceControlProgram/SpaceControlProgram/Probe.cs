namespace SpaceControlProgram;

abstract class Probe
{
    public string Alias
    { get;  set; }

    public int YearLanded
    { get;  set; }

    public Probe(string alias, int yearLanded)
    {
        Alias = alias;
        YearLanded = yearLanded;
    }
}