using EmployeeAPI.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

    public class EmployementDateValidation : ValidationAttribute
    {
     protected override ValidationResult IsValid (object value, ValidationContext validationContext)
      {
        var addEmployeeDto = (AddEmployeeDto)validationContext.ObjectInstance;
           if (DateTime.Compare(addEmployeeDto.EmploymentDate, DateTime.Today)> 0)
           {
               return new ValidationResult("EmploymentDate cannot be a future date.");
           }
           if (DateTime.Compare(addEmployeeDto.EmploymentDate, new DateTime(2000, 01, 01)) > 0)
           {
               return new ValidationResult("EmploymentDate cannot be earlier than 2000-01-01.");
           }
            return new ValidationResult("Something went wrong");
      }
}

