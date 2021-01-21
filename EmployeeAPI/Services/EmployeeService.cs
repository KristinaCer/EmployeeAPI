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

        public async Task<ServiceResponse<List<Employee>>> AddEmployee(Employee newEmployee)
        {
            ServiceResponse<List<Employee>> serviceResponse = new ServiceResponse<List<Employee>>();
            employees.Add(newEmployee);
            serviceResponse.Data = employees;
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<Employee>>> DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Employee>>> GetAllEmployees()
        {
            ServiceResponse<List<Employee>> serviceResponse = new ServiceResponse<List<Employee>>();
            serviceResponse.Data = employees;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Employee>> GetEmployeeById(int id)
        {
            ServiceResponse<Employee> serviceResponse = new ServiceResponse<Employee>();
            serviceResponse.Data = employees.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Employee>>> UpdateEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
