using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hobbies = new string[]
            {
                " Boxing,",
                " Swimming,",
                " Hiking,",
                " Driving a sport car.",
            };
            
            Profile Sam =  new Profile("Sam Winchester", 28, "Cansas", "USA", "he/him", "boxing");
            
            Sam.SetHobby("smth");
            foreach (var element in hobbies)
            {
                Sam.Hobby += element;
            }
            
            Console.WriteLine(Sam.ViewProfile());

            Profile Jake = new Profile("Jake Johnson", 19);
            Jake.SetHobby("Swimming");
            Console.WriteLine(Jake.ViewProfile());
        }
    }
}