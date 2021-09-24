using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject wipro=new EmpWageBuilderObject("wipro", 30, 20, 100);
            wipro.computeEmpWage();
            Console.WriteLine(wipro.tostring());
            EmpWageBuilderObject Tcs = new EmpWageBuilderObject("tcs", 40, 30, 120);
            Tcs.computeEmpWage();
            Console.WriteLine(Tcs.tostring());
            
        }
    }
}
