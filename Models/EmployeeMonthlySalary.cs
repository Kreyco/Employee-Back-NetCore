﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EmployeeMonthlySalary : Employee
    {
        public override double CalculateAnnualSalary (double HourlySalary, double MonthlySalary)
        {
            return MonthlySalary * 12;
        }
    }
}
