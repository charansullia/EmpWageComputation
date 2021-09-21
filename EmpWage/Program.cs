using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageComputation.EmpWage("wipro", 30, 20, 100);
            EmpWageComputation.EmpWage("Tcs", 20, 50, 150);
            EmpWageComputation.EmpWage("infosys", 30, 40, 100);
        }
    }
}
