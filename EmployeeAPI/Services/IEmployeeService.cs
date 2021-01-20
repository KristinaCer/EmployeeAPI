using System;
using System.Collections.Generic;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        List<Employee> AddEmployee(Employee employee);
        List<Employee> UpdateEmployee(Employee employee);
        List<Employee> DeleteEmployee(Employee employee);

    }
}
