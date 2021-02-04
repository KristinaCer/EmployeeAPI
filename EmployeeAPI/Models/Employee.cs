using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeAPI.Utils.DataValidation;

namespace EmployeeAPI.Models
{
    /*
    For simplification, I assume that an employee can have
    only one boss.*/
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime EmploymentDate { get; set; }

        public string HomeAddress { get; set; }

        public double Salary { get; set; }

        public int BossId { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
