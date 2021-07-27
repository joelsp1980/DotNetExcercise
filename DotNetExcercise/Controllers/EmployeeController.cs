using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Data.Model;
using Services;
using System.Threading.Tasks;

namespace DotNetExcercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Employee> Get()
        {
            IEmployeeService employeeService = new EmployeeService();

            var result = employeeService.GetEmployees();

            return result;
        }

        [HttpPut]
        [Route("Add") ]
        public Employee Add(Employee newEmployee)
        {
            IEmployeeService employeeService = new EmployeeService();
            Employee employee = employeeService.AddEmployee(newEmployee);

            return employee;
        }

        [HttpPut]
        [Route("Update")]
        public string Update(Employee newEmployee)
        {
            IEmployeeService employeeService = new EmployeeService();
            var result = employeeService.UpdateEmployee(newEmployee);

            return result;
        }

        [HttpDelete]
        public string Delete(Employee employee)
        {
            IEmployeeService employeeService = new EmployeeService();
            var result = employeeService.DeleteEmployee(employee);

            return result;
        }
    }
}
