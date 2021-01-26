using System;
using System.Collections.Generic;

namespace EmployeeAPI.Models
{
    /*
    For the simplification reasons, I assume that employee can have
    only one salary, one boss and one role since his/her start of employement.*/
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string HomeAddress { get; set; }
        public double Salary { get; set; }
        public string Role { get; set; }
        public int BossId { get; set; }
    }
}
