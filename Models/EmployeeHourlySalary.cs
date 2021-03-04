using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WebApplication2.Models
{
    public class EmployeeHourlySalary : Employee
    {
        public override double CalculateAnnualSalary(double HourlySalary, double MonthlySalary)
        {
            return 120 * HourlySalary * 12;
        }
    }
}
