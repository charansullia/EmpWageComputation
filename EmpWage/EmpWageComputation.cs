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
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHr = 8;
                        break;

                    case 2:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalWage = (empHr * empRatePerHr);
                Console.WriteLine("total employee wage is:" + totalWage);

            }

        }
    }
}