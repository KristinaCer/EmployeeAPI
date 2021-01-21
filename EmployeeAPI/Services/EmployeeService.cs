using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAPI.Dtos;
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
        private readonly IMapper mapper;

        public EmployeeService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto newEmployee)
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            employees.Add(this.mapper.Map<Employee>(newEmployee));
            serviceResponse.Data = (employees.Select(c => this.mapper.Map<GetEmployeeDto>(c))).ToList();
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetEmployeeDto>>> GetAllEmployees()
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            serviceResponse.Data = (employees.Select(c => this.mapper.Map<GetEmployeeDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetEmployeeDto>> GetEmployeeById(int id)
        {
            ServiceResponse<GetEmployeeDto> serviceResponse = new ServiceResponse<GetEmployeeDto>();
            serviceResponse.Data = this.mapper.Map<GetEmployeeDto>(employees.FirstOrDefault(c => c.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetEmployeeDto>> DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmployeeDto updatedEmployee)
        {
            ServiceResponse<GetEmployeeDto> serviceResponse = new ServiceResponse<GetEmployeeDto>();
            Employee employee = employees.FirstOrDefault(c => c.Id == updatedEmployee.Id);
            employee.FirstName = updatedEmployee.FirstName;
            employee.LastName = updatedEmployee.LastName;
            employee.BirthDate = updatedEmployee.BirthDate;
            serviceResponse.Data = this.mapper.Map<GetEmployeeDto>(employee);
            return serviceResponse;
        }
    }
}
