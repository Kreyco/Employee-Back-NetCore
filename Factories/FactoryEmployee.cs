using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Factories
{
    public enum ContractType
    {
        HourlySalaryEmployee,
        MonthlySalaryEmployee
    }

    public static class FactoryEmployee
    {
        public static Nullable<double> CalculateAnnualSalary(ContractType contractTypeName, double HourlySalary, double MonthlySalary)
        {
            if (contractTypeName == ContractType.HourlySalaryEmployee)
            {
                return new EmployeeHourlySalary().CalculateAnnualSalary(HourlySalary, MonthlySalary);
            }
            else if (contractTypeName == ContractType.MonthlySalaryEmployee)
            {
                return new EmployeeMonthlySalary().CalculateAnnualSalary(HourlySalary, MonthlySalary);
            }
            else
            {
                return null;
            }
        }
    }
}
