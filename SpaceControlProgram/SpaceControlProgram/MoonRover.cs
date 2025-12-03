namespace SpaceControlProgram;

class MoonRover : Rover
{

    public MoonRover(string alias, int yearLanded) : base (alias, yearLanded)
    {
    }

    public string Explore()
    {
        return "Moon rover is exploring the surface!";
    }

    public string Collect()
    {
        return "Moon rover is collecting rocks!";
    }
}