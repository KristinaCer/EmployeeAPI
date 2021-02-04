using EmployeeAPI.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Utils.DataValidation
{
    public class BirthDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var addEmployeeDto = (AddEmployeeDto)validationContext.ObjectInstance;
            int age = calculateAge(addEmployeeDto.BirthDate);
            if ( age > 70 || age < 18)
            {
                return new ValidationResult("Employee must be at least 18 years old and not older than 70 years.");
            }
            return ValidationResult.Success;
        }

        public int calculateAge(DateTime dt)
        {
            var today = DateTime.Today;
            var age = today.Year - dt.Year;
            // Go back to the year in which the person was born in case of a leap year
            if (dt.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
