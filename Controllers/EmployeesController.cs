using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Repository;
using WebApplication2.Models;
using Microsoft.AspNetCore.Http;
using WebApplication2.Factories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        [HttpGet]
        public List<Employee> Get()
        {
            //api/employees
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.GetResponse("Employees");
                response.EnsureSuccessStatusCode();

                List<Employee> employees = response.Content.ReadAsAsync<List<Employee>>().Result;

                foreach (var employee in employees)
                {
                    employee.CalculatedAnnualSalary = FactoryEmployee.CalculateAnnualSalary(employee.ContractTypeName, employee.HourlySalary, employee.MonthlySalary);
                }

                return employees;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.GetType());
                throw;
            }
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public List<Employee> Get(int id)
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.GetResponse("Employees");
                response.EnsureSuccessStatusCode();

                List<Employee> employees = response.Content.ReadAsAsync<List<Employee>>().Result;
                Employee employee = employees.Find(x => x.Id == id);
                employee.CalculatedAnnualSalary = FactoryEmployee.CalculateAnnualSalary(employee.ContractTypeName, employee.HourlySalary, employee.MonthlySalary);
                List<Employee> result = new List<Employee>
                {
                    employee
                };

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.GetType());
                throw;
            }
        }
    }
}
