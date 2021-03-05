using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
	public class Employee
	{
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		[Required, DisplayName("User")]
		public String Name { get; set; }
		public String ContractTypeName { get; set; }
		public int RoleId { get; set; }
		public String RoleName { get; set; }
		public String RoleDescription { get; set; }
		private String hourlySalary;
		[DisplayName("HourlySalary")]
		public double HourlySalary { get => Double.Parse(hourlySalary); set => hourlySalary = value.ToString(); }
		private String monthlySalary;
		[DisplayName("MonthlySalary")]
		public double MonthlySalary { get => Double.Parse(monthlySalary); set => monthlySalary = value.ToString(); }
		private double calculatedAnnualSalary;
		public double CalculatedAnnualSalary { get; set; }

        public virtual double CalculateAnnualSalary(double HourlySalary, double MonthlySalary)
		{
			return 0;
		}
	}
}
