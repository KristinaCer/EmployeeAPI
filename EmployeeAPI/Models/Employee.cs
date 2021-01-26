using System;
using System.Collections.Generic;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = "Kristina";
        public string LastName { get; set; } = "Cer";
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string HomeAddress { get; set; } = "UKNOWN";
        public List<Role> Roles { get; set; }
        public List<Salary> Salaries { get; set; }

    }
}
