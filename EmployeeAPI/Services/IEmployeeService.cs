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
        Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmployeeDto employee);
        Task<ServiceResponse<GetEmployeeDto>> DeleteEmployee(Employee employee);
    }
}
