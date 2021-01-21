﻿using System.Threading.Tasks;
using EmployeeAPI.Dtos;
using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        [Route("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await this.employeeService.GetEmployeeById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeDto newEmployee)
        {
            return Ok(await this.employeeService.AddEmployee(newEmployee));
        }       
    }
}
