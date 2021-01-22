using System;
namespace EmployeeAPI.Dtos
{
    public class AddEmployeeDto
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } = "Cer";
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Boss { get; set; } = "UKNOWN";
        public string HomeAddress { get; set; } = "UKNOWN";
        public double CurrentSalary { get; set; } = 1050.50;
        public string Role { get; set; } = "Software Developer";
    }
}
