using System;
using System.Collections.Generic;
using Data.Model;

namespace Data.DataAccess
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var employees = new List<Employee>
            {
            new Employee{FirstName="Paco",LastName="Perez",Age=30,Gender=Gender.Male},
            new Employee{FirstName="Mike",LastName="Johnson",Age=31,Gender=Gender.Male},
            new Employee{FirstName="Michael",LastName="Jordan",Age=32,Gender=Gender.Male},
            new Employee{FirstName="Troy",LastName="Aikman",Age=43,Gender=Gender.Male},
            new Employee{FirstName="Angela",LastName="Li",Age=37,Gender=Gender.Female},
            new Employee{FirstName="Lupita",LastName="Herrera",Age=39,Gender=Gender.Female},
            new Employee{FirstName="Laura",LastName="Rodriguez",Age=29,Gender=Gender.Female}
             };

            foreach (Employee employee in employees)
                context.Employees.Add(employee);

            base.Seed(context);
        }
    }
}

