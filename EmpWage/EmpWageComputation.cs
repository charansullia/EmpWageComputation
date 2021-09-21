using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int EmpWage(string companyname, int wageperhour, int workingdayspermonth, int totalworkinghoursinamonth)
        {
            int emphours = 0;
            int wagespermonth = 0;
            int totalworkingdays = 0;
            int employeehrinmonth = 0;
            while (employeehrinmonth < totalworkinghoursinamonth && totalworkingdays < workingdayspermonth)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 2);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        emphours = 8;
                        break;
                    case IS_PART_TIME:
                        emphours = 8;
                        break;
                }
                employeehrinmonth = employeehrinmonth + emphours;
            }
            wagespermonth +=employeehrinmonth*wageperhour ;
            Console.WriteLine("Company name is " + companyname + " and total wage is " + wagespermonth);
            return wagespermonth;
        }
    }
}

