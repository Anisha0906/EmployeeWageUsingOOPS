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
        public int Total_Salary_Month = 0;
        public int Day;
        public int empHrs = 0;
        public int EmployeeWage;
        public void Attendance()
        {
            for (Day = 1; Day <= Working_Days_Per_Month; Day++)
            {
                Random random = new Random(); 
                int empCheck = random.Next(0, 3); 
                switch (empCheck) 
                {
                    case Emp_Full_Time:
                        empHrs = 8; 
                        break;

                    case Emp_Part_Time: 
                        empHrs = 4; 
                        break;

                    default:
                        empHrs = 0; 
                        break;
                }
            } 
            EmployeeWage = empHrs * Working_Days_Per_Month;
            Total_Salary_Month += EmployeeWage;  
            Console.WriteLine("Employee Wage : " + EmployeeWage); 
        }
    }
}