using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeAPI.Utils.DataValidation;

namespace EmployeeAPI.Models
{
    /*
    For simplification, I assume that employee can have
    only one boss.*/
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Employee first name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Employee last name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime EmploymentDate { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        [Required]
        public double Salary { get; set; }

        public int BossId { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
