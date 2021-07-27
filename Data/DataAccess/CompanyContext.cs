using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Data.Model;

namespace Data.DataAccess
{
    public class CompanyContext : DbContext 
    {
        public CompanyContext() : base("CompanyDatabase")
        {
            Database.SetInitializer(new EmployeeInitializer());
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Employee>()
                .HasKey(e => new { e.FirstName, e.LastName, e.Email });
        }
             
    }
}
