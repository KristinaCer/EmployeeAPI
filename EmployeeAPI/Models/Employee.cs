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

        [DataType(DataType.Date)]
        [Required]
        [BirthDateValidation(ErrorMessage = "E​mployee must be at least 18 years old and not older than 70 years")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [EmployementDateValidation(ErrorMessage = "Employement date cannot be earlier than 2000-01-01 or a future date.")]
        public DateTime EmploymentDate { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        [Required]
        [SalaryValidation(ErrorMessage = "Salary must be non-negative.")]
        public double Salary { get; set; }

        public int BossId { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
