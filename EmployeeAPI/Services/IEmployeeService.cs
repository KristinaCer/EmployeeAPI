using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<List<Employee>> AddEmployee(Employee employee);
        Task<List<Employee>> UpdateEmployee(Employee employee);
        Task<List<Employee>> DeleteEmployee(Employee employee);

    }
}
