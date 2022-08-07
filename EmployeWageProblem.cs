using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmpWageBuilderObject
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        private string CompanyName;
        private int WagePerHour;
        private int NumWorkingDays;
        private int MaxHoursPerMonth;
        private int totalWage;

        public EmpWageBuilderObject(string CompanyName, int WagePerHour, int NumWorkingDays, int MaxHoursPerMonth)
        {
            this.CompanyName = CompanyName;
            this.WagePerHour = WagePerHour;
            this.NumWorkingDays = NumWorkingDays;
            this.MaxHoursPerMonth = MaxHoursPerMonth;
        }
        public void Attendance()
        {

            int DailyWage = 0;
            int days, isPresent;
            int totalHours = 0;
            Random rand = new Random();
            for (days = 1; days <= this.NumWorkingDays; days++) 
            {
                isPresent = rand.Next(0, 3);
                 switch (isPresent)
                {
                    case Emp_Full_Time: 
                        {
                            DailyWage = this.WagePerHour * 8;
                            break;
                        }
                    case Emp_Part_Time: 
                        {
                            DailyWage = this.WagePerHour * 4;
                            break;
                        }
                    default: 
                        {
                            DailyWage = isPresent;
                            break;
                        }
                }
                totalHours += DailyWage / 20; 
                totalWage += DailyWage; 
                if (totalHours >= this.MaxHoursPerMonth)  
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"Company Name :{this.CompanyName}"); 
            Console.WriteLine($"No. of hours worked :{totalHours}"); 
            Console.WriteLine($"Wage Per hour :{this.WagePerHour}"); 
            Console.WriteLine($"Monthly wage :{this.totalWage}");
        }

        public string Result()
        {
           return "Total Employee wage for Comapny : " + this.CompanyName + " is " + this.totalWage;
        }
    }
}