﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAPI.Dtos;
using EmployeeAPI.Models;
using EmployeeAPI.SolutionData;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Services
{
    public class EmployeeService : IEmployeeService
    { 
        private readonly IMapper mapper;
        private readonly DataContext context;

        public EmployeeService(IMapper mapper, DataContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto newEmployee)
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            Employee employee = this.mapper.Map<Employee>(newEmployee);
            await this.context.Employees.AddAsync(employee);
            await this.context.SaveChangesAsync();
            serviceResponse.Data = (this.context.Employees.Select(c => this.mapper.Map<GetEmployeeDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetEmployeeDto>>> GetAllEmployees()
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            List<Employee> dbEmployees = await this.context.Employees.ToListAsync();
            serviceResponse.Data = (dbEmployees.Select(c => this.mapper.Map<GetEmployeeDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetEmployeeDto>> GetEmployeeById(int id)
        {
            ServiceResponse<GetEmployeeDto> serviceResponse = new ServiceResponse<GetEmployeeDto>();
            Employee dbEmployee = await this.context.Employees.FirstOrDefaultAsync(c => c.Id == id);
            serviceResponse.Data = this.mapper.Map<GetEmployeeDto>(dbEmployee);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetEmployeeDto>>> DeleteEmployee(int id)
        {
            ServiceResponse<List<GetEmployeeDto>> serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
            try
            {
                Employee employee = await this.context.Employees.FirstAsync(c => c.Id == id);
                this.context.Employees.Remove(employee);
                await this.context.SaveChangesAsync();
                serviceResponse.Data = (this.context.Employees.Select(c => this.mapper.Map<GetEmployeeDto>(c))).ToList();
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
                Employee employee = await this.context.Employees.FirstOrDefaultAsync(c => c.Id == updatedEmployee.Id);

                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.BirthDate = updatedEmployee.BirthDate;
                employee.EmploymentDate = updatedEmployee.EmploymentDate;
                employee.HomeAddress = updatedEmployee.HomeAddress;
             
                this.context.Employees.Update(employee);
                await this.context.SaveChangesAsync();
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
