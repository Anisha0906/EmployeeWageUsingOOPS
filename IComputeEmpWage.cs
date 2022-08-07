using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{   
    interface IComputeEmpWage
    {
        void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        int ComputeMonthlyWage(CompanyEmpWage company);
        void DisplayCompanyWages();
    }
}