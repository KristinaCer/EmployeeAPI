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
            new Employee{ Id = 1, FirstName = "Jonas", LastName = "Jonaitis" }
        };
        private readonly IMapper mapper;

        public EmployeeService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto newEmployee)
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            Employee employee = this.mapper.Map<Employee>(newEmployee);
            employee.Id = employees.Max(c => c.Id) + 1;
            employees.Add(employee);
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

        public async Task<ServiceResponse<List<GetEmployeeDto>>> DeleteEmployee(int id)
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            try
            {
                Employee employee = employees.First(c => c.Id == id);
                employees.Remove(employee);
                serviceResponse.Data = (employees.Select(c => this.mapper.Map<GetEmployeeDto>(c))).ToList();
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmployeeDto updatedEmployee)
        {
            ServiceResponse<GetEmployeeDto> serviceResponse = new ServiceResponse<GetEmployeeDto>();
            try
            {
                Employee employee = employees.FirstOrDefault(c => c.Id == updatedEmployee.Id);
                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.BirthDate = updatedEmployee.BirthDate;
                employee.EmploymentDate = updatedEmployee.EmploymentDate;
                employee.HomeAddress = updatedEmployee.HomeAddress;
                employee.Boss = updatedEmployee.Boss;
                employee.CurrentSalary = updatedEmployee.CurrentSalary;
                serviceResponse.Data = this.mapper.Map<GetEmployeeDto>(employee);
            } catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
