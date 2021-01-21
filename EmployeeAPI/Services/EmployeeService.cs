using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee(),
            new Employee{ FirstName = "Jonas", LastName = "Jonaitis" }
        };

        public EmployeeService()
        {
        }

        public async Task<List<Employee>> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return employees;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(c => c.Id == id);
        }

        public async Task<List<Employee>> UpdateEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
            return employees;
        }
    }
}
