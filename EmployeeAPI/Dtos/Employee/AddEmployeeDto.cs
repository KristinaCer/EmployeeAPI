using EmployeeAPI.Utils.DataValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Dtos
{
    public class AddEmployeeDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Employee first name cannot be longer than 50 characters")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Employee last name cannot be longer than 50 characters")]
        public string LastName { get; set; }
        [BirthDateValidation]
        public DateTime BirthDate { get; set; }
        [EmployementDateValidation]
        public DateTime EmploymentDate { get; set; }
        [Required]
        public string HomeAddress { get; set; }
        [SalaryValidation]
        public double Salary { get; set; }
        public int BossId { get; set; }
    }
}
