using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        public const int IS_FULL_TIME_PRESENT = 1;
        public const int IS_PART_TIME_PRESENT = 2;
        public const int empRatePerHr = 20;
        public const int WorkingDayPerMonth = 20;
        public void EmpComputation()
        {
            int empHr = 0;
            int empWage = 0;
            int totalempWage = 0;
            for (int day = 0; day < WorkingDayPerMonth; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME_PRESENT:
                        empHr = 8;
                        break;

                    case IS_PART_TIME_PRESENT:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }

                empWage = empRatePerHr * empHr;
                Console.WriteLine("emp wage is:" + empWage);
            }
                totalempWage += empWage;
                Console.WriteLine("emp totalwage is:" + totalempWage);

        }
    }
}