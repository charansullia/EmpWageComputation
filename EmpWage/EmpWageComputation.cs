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
        public const int WorkingHrPerMonth = 100;
        public void EmpComputation()
        {
            int empHr = 0;
            int totalempHr = 0;
            int totalWorkingDays = 0;
            while (totalempHr < WorkingHrPerMonth && totalWorkingDays < WorkingDayPerMonth)
            {
                totalWorkingDays++;
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
                totalempHr += empHr;
                Console.WriteLine("employee working day in month:" + totalWorkingDays + "totalempHr:" + totalempHr);
            }
            int totalempWage = totalempHr * empRatePerHr;
            Console.WriteLine("emp wage is:" + totalempWage);

        }
    }
}
