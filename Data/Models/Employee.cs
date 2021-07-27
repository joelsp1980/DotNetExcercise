using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    [Table("Employee")]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
