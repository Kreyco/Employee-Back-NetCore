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
		[DisplayName("HourlySalary")]
		public String HourlySalary { get; set; }
		[DisplayName("MonthlySalary")]
		public String MonthlySalary { get; set; }
		public double CalculatedAnnualSalary { get => CalculateAnnualSalary(double.Parse(HourlySalary), double.Parse(MonthlySalary)); set { this.CalculatedAnnualSalary = value; } }

        public virtual double CalculateAnnualSalary(double HourlySalary, double MonthlySalary)
		{
			return 0;
		}
	}
}
