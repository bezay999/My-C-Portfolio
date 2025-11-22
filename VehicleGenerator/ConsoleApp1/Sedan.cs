using System;

namespace LearnInheritance
{
    class Sedan : Vehicle
    {
   
        public Sedan(double speed) : base(speed){
            Wheels = 4;
        }
        
    }
}