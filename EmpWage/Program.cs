using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder=new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 30, 20, 90);
            empWageBuilder.addCompanyEmpWage("tcs", 40, 30, 120);
            empWageBuilder.computeEmpWage();
            
        }
    }
}
