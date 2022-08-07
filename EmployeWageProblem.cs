using EmployeeWageProblemUsingOops;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeWageProblem : IComputeEmpWage

    {
         public int FULL_DAY_HOUR = 8;
        public int PART_TIME_HOUR = 4;
        const int EMP_FULL_TIME = 1;
        const int EMP_PART_TIME = 2;
         ArrayList companies;
        int noOfCompanies;
         public EmployeWageProblem()
        {
             companies = new ArrayList();
        }
         public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
             CompanyEmpWage company = new CompanyEmpWage(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
            company.setWagesPerMonth(this.ComputeMonthlyWage(company));
            companies.Add(company);
         }
         public void AddCompany(CompanyEmpWage company)
        {
            company.setWagesPerMonth(this.ComputeMonthlyWage(company));
            companies.Add(company);
        }
         public int ComputeMonthlyWage(CompanyEmpWage company)
        {
             int workingHours = 0;
            int workingDays = 0;
            int wagesPerMonth = 0;
            int attendance;
            int empHrs = 0;
            Random rand = new Random();
            while (workingHours < company.maxWorkingHours && workingDays < company.maxWorkingDays)
            {
                attendance = rand.Next(0, 3); 
                switch (attendance)
                {
                    case EMP_FULL_TIME:
                        workingDays += 1; 
                        empHrs = FULL_DAY_HOUR;  
                        break;
                     case EMP_PART_TIME:
                        workingDays += 1; 
                        empHrs = PART_TIME_HOUR; 
                        break;
                    default:
                        break;
                }
                workingHours += empHrs;
                 wagesPerMonth += (company.wagePerHour * workingHours);

            }
            return wagesPerMonth;
        } 

        public void DisplayCompanyWages()
        {
            foreach (CompanyEmpWage company in companies)
            {
                company.printMonthlyWage();
            }
        }
    }
}