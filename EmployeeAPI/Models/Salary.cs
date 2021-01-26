using System;
namespace EmployeeAPI.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public double CurrentSalary { get; set; } = 1050.50;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Employee Employee { get; set; }
    }
}
