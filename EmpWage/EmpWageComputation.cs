using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        public void EmpComputation()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck==IS_PRESENT)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }

        }
        
    }
}
