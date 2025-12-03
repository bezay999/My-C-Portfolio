using System;

namespace CorporatePolymorphism
{
    public class HR : Employee
    {
        public override void SubmitDailyReport()
        {
            Console.WriteLine("HR submits daily report.");
        }

        public override void Work()
        {
            Console.WriteLine("HR handles employee matters.");
        }
    }
}