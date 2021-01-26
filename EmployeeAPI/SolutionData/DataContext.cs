using System;
using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.SolutionData
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> EmployeeRoles { get; set; }
        public DbSet<Salary> EmployeeSalaries{ get; set; }
    }
}
