using System;
namespace EmployeeAPI.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = "Software Developer";
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Employee Employee { get; set; }
    }
}
