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
            EmployeWageProblem EmployeeWage = new EmployeWageProblem();
            EmployeeWage.Attendance();
            Console.ReadKey();
        }
    }
}
