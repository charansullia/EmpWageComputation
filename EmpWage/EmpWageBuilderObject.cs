using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EmpWage
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHr;
        private int numofWorkingDays;
        private int maxHrPerMonth;
        private int totalEmpWage;
    
        public EmpWageBuilderObject(string company, int empRatePerHr, int numofWorkingDays, int maxHrPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHrPerMonth = maxHrPerMonth;
        }
        public  void computeEmpWage()
        {
            int empHr = 0, totalEmpHr = 0, totalWorkingDays = 0;
            while (totalEmpHr < this.maxHrPerMonth && totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHr += empHr;
                Console.WriteLine("totalnumberofworking days:" + totalWorkingDays + "totalworkingHr:" + totalEmpHr);
            }
            totalEmpWage = totalEmpHr * empRatePerHr;
        }

        public string tostring()
        {
            return "totalEmpWageForCompany:" + company + "is" + totalEmpWage;
            Console.WriteLine("---------------------------------------------");
        }
    }

}
