namespace SpaceControlProgram;

class MarsRover : Rover
{

    public MarsRover(string alias, int yearLanded) : base (alias, yearLanded)
    {
    }

    public string Explore()
    {
        return "Mars rover is exploring the surface!";
    }

    public string Collect()
    {
        return "Mars rover is collecting rocks!";
    }
}
