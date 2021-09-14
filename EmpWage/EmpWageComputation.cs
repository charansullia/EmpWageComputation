using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        public void EmpComputation()
        {
            int IS_FULL_TIME_PRESENT = 1;
            int IS_PART_TIME_PRESENT = 2;
            int empRatePerHr = 20;
            int empHr = 0;
            int totalWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck==IS_FULL_TIME_PRESENT)
            {
                empHr = 8;
            }
            else if(empCheck==IS_PART_TIME_PRESENT)
            {
                empHr = 4;
            }
            else
            {
                empHr = 0;
            }
            totalWage = (empHr * empRatePerHr);
            Console.WriteLine("total employee wage is:" + totalWage);

        }
        
    }
}
