using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        Task<ServiceResponse<List<Employee>>> GetAllEmployees();
        Task<ServiceResponse<Employee>> GetEmployeeById(int id);
        Task<ServiceResponse<List<Employee>>> AddEmployee(Employee employee);
        Task<ServiceResponse<List<Employee>>> UpdateEmployee(Employee employee);
        Task<ServiceResponse<List<Employee>>> DeleteEmployee(Employee employee);
    }
}
