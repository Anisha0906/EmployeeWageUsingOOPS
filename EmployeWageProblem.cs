using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    class EmployeWageProblem
    {
        public int IS_PRESENT = 1;
        public int Wage_Per_Hours = 20;
         readonly int Emp_Full_Time = 2;
        readonly int Emp_Part_Time = 1;
        public int empHrs;
        public int EmployeeWage;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Emp_Full_Time)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (empCheck ==Emp_Part_Time)
            {
                Console.WriteLine("Employee is Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            EmployeeWage = empHrs * Wage_Per_Hours;
            Console.WriteLine("Employee Full Wage is : " + EmployeeWage); 
        }
    }
}