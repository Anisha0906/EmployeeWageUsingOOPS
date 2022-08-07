using EmployeeWageProblem;
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
            EmployeWageProblem empWageBuilder = new EmployeWageProblem();
           empWageBuilder.AddCompany("TCS", 20, 2, 10);
            empWageBuilder.AddCompany("TATA", 20, 2, 10);
            empWageBuilder.AddCompany("Infoys", 20, 2, 10);
            empWageBuilder.AddCompany("Google", 20, 2, 10);
            empWageBuilder.DisplayCompanyWages();
            empWageBuilder.DisplayCompanyDailyWages();
            Console.ReadKey();
        }


    }
}