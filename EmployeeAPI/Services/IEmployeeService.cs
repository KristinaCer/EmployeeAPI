using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAPI.Dtos;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        Task<ServiceResponse<List<GetEmployeeDto>>> GetAllEmployees();
        Task<ServiceResponse<GetEmployeeDto>> GetEmployeeById(int id);
        Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto employee);
        Task<ServiceResponse<List<Employee>>> UpdateEmployee(Employee employee);
        Task<ServiceResponse<List<Employee>>> DeleteEmployee(Employee employee);
    }
}
