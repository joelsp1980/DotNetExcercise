using Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee AddEmployee(Employee newEmployee);

        string DeleteEmployee(Employee deleteEmployee);

        string UpdateEmployee(Employee updateEmployee);

    }
}
