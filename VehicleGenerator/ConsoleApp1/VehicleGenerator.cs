using System;
using LearnInheritance;

namespace VehicleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
            s.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {s.Speed}");
      
            Truck t = new Truck(45, 500);
            Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels} wheels, driving at {t.Speed} km/h.");
            t.SpeedUp();
            Console.WriteLine($"Truck's faster speed: {t.Speed}");
      
            Vehicle b = new Vehicle(10);
            Console.WriteLine($"Bicycle with {b.Wheels} wheels, driving at {b.Speed} km/h.");
            b.SpeedUp();
            Console.WriteLine($"Biclycle's faster speed: {b.Speed}");
        }
    }
}