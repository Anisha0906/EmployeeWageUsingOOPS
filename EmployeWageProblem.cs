using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    class EmployeWageProblem
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
         public int Working_Days_Per_Month = 20;
        public int Working_Days = 0;
        public int empHrs = 0;
        public int EmployeeWage = 0;
        int totalWage = 0;
        int totalHours = 0;
        public void Attendance(string CompanyName, int WagePerHour, int NumWorkingDays, int MaxHoursPerMonth) //
        {
            for (int Day = 1; Day <= Working_Days_Per_Month; Day++)
            {
                Random random = new Random(); 

                int empCheck = random.Next(0, 3); 
                switch (empCheck) 
                {
                    case Emp_Full_Time: 
                        empHrs = WagePerHour * 8;
                        break;

                    case Emp_Part_Time: 
                        empHrs = WagePerHour * 4; 
                        break;

                    default:
                        empHrs = 0; 
                        break;
                }

               totalHours += empHrs / 20; 
                totalWage += empHrs; 
                if (totalHours >= MaxHoursPerMonth) 
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Company Name :" + CompanyName);
            Console.WriteLine("Number Of Hour Employee  Worked  :" + totalHours);
            Console.WriteLine("Employee Wage Per Hour :" + WagePerHour);
            Console.WriteLine("Monthly wage :" + totalWage);
            Console.WriteLine();
        }
    }
}
