using System;

namespace LearnInheritance
{
    class Vehicle
    {
        public string LicensePlate
        { get; private set; }

        public double Speed
        { get; private set; }

        public int Wheels
        {
            get;
            protected set;
        } = 2;

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
    
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        public Vehicle(double speed)
        {
            Speed = speed;
            Random rnd = new Random();

            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                letters += (char)rnd.Next('A', 'Z' + 1);
            }

            int numbers = rnd.Next(0, 9999);

            string licensePlate = $"{letters}-{numbers:D4}";
            LicensePlate = licensePlate;
        }

    }
}