using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        { 
            Employee hrRep = new HR();
            Employee employee1 = new Engineer();
            Employee employee2 = new Intern();
            Employee employee3 = new Manager();
            
            Engineer engineer = employee1 as Engineer;
            if (engineer != null)
            {
                engineer.SubmitDailyReport();
            }
            else
            {
                Console.WriteLine("Downcast is failed");
            }

            hrRep.ClockIn();
            hrRep.Work();
            hrRep.SubmitDailyReport();
            Console.WriteLine(); 
            employee1.SubmitDailyReport();
            employee2.Work();
            employee3.Work();
            
            
            Employee [] newList = {hrRep, employee1, employee2, employee3};
            foreach (Employee e in newList)
                {
                e.SubmitDailyReport();
                e.Work();
                e.ClockIn();
                }

            if (employee1 is Engineer)
            {
                Console.WriteLine("Employee1 is Engineer");
            }
        }
    }
}