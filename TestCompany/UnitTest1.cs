using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Data.Model;

namespace TestCompany
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Employee_Test()
        {
            IEmployeeService employeeService = new EmployeeService();
            Employee employee = new Employee();

            employee.FirstName = "Name";
            employee.LastName = "LastName";
            employee.Email = "Email";
            employee.Age = 25;
            employee.Gender = Gender.Male;

            Employee newEmployee = employeeService.AddEmployee(employee);

            Assert.AreNotEqual(newEmployee, null);
        }
    }
}
