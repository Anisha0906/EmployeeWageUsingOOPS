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
        public int Count_Work_Day = 20;
        public int Emp_Per_Rate_Hour = 20;
        public int MAx_Hrs_Or_Day_Month = 100;
        public int Working_Days = 0;
        public int empHrs = 0;
        public int EmployeeWage = 0;
        public int EmpSalary;
        public void Attendance()
        {
            while (empHrs <= MAx_Hrs_Or_Day_Month && Working_Days < Count_Work_Day)  
            {
                Working_Days++; 
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
                EmployeeWage += empHrs; 
                Console.WriteLine("Day#:" + Working_Days + "Employee Hrs:" + empHrs);
            }
            EmpSalary = EmployeeWage + Emp_Per_Rate_Hour; 
            Console.WriteLine("Employee Wage : " + EmployeeWage); 
        }
    }
}
