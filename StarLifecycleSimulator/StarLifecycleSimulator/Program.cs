using System;

namespace StarLifecycleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Star Simulations */

            Star sun = new Star("Sun", "G-Type");
            sun.Shine();
            sun.GrowOlder();
            sun.Shine();
            sun.Supernova();

            Star unknownStar = new Star("Mystery Star");
            unknownStar.Shine();
            unknownStar.GrowOlder();
        }
    }
}