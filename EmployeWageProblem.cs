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
        public int Full_Day_Hour = 8;
        public int EmployeeWage;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                CalculateDailyWage();
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee Wage is null");
            }

        }
        public void CalculateDailyWage()
        {
            EmployeeWage = Wage_Per_Hours * Full_Day_Hour;
            Console.WriteLine("Employee Full Wage is : " + EmployeeWage);
        }
    }
}