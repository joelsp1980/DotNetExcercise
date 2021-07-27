using System.Linq;
using Data.Model;
using Data.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees () 
        {
            CompanyContext companyContext = new CompanyContext();
            IQueryable<Employee> employees = companyContext.Employees;

            return employees.ToList();
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            CompanyContext companyContext = new CompanyContext();
            companyContext.Employees.Add(newEmployee);

            companyContext.SaveChanges();

            return newEmployee;
        }

        public string UpdateEmployee(Employee updateEmployee)
        {
            CompanyContext companyContext = new CompanyContext();
            var employee = companyContext.Employees.SingleOrDefault(e => e.FirstName == updateEmployee.FirstName
                                                                         && e.LastName == updateEmployee.LastName
                                                                         && e.Email == updateEmployee.Email);

            if (employee == null)
            {
                return string.Format("Employee {0} {1}, {2} does not exist in database", updateEmployee.FirstName, updateEmployee.LastName, updateEmployee.Email);
            }
            else
            {
                employee.Age = updateEmployee.Age;
                employee.Gender = updateEmployee.Gender;

                companyContext.SaveChanges();
            }

            return string.Format("Employee {0} {1}, {2} updated succesfully.", updateEmployee.FirstName, updateEmployee.LastName, updateEmployee.Email);
        }

        public string DeleteEmployee(Employee deleteEmployee)
        {
            CompanyContext companyContext = new CompanyContext();
            var delEmployee = companyContext.Employees.SingleOrDefault(e => e.FirstName == deleteEmployee.FirstName
                                                             && e.LastName == deleteEmployee.LastName
                                                             && e.Email == deleteEmployee.Email);

            if (delEmployee == null)
            {
                return string.Format("Employee {0} {1}, {2} does not exist in database", deleteEmployee.FirstName, deleteEmployee.LastName, deleteEmployee.Email);
            }
            else
            {
                companyContext.Employees.Remove(delEmployee);
                companyContext.SaveChanges();
            }

            return string.Format("Employee {0} {1}, {2} deleted succesfully.", deleteEmployee.FirstName, deleteEmployee.LastName, deleteEmployee.Email);
        }
    }
}
