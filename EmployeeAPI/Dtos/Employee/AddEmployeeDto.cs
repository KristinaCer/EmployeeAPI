﻿using System;
namespace EmployeeAPI.Dtos
{
    public class AddEmployeeDto
    {
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
