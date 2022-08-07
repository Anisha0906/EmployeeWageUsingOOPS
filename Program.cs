using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWageProblem.EmpWageBuilderObject DMart = new EmployeeWageProblem.EmpWageBuilderObject("DMart", 20, 2, 10);
            EmployeeWageProblem.EmpWageBuilderObject BigBazar = new EmployeeWageProblem.EmpWageBuilderObject("BigBazar", 10, 4, 20);
            DMart.Attendance();
            Console.WriteLine(DMart.Result());
            BigBazar.Attendance();
            Console.WriteLine(BigBazar.Result());
            Console.ReadKey();
        }
    }
}