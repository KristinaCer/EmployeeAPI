using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Get()
        {
            return Ok(this.employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(this.employeeService.GetEmployeeById(id));
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee newEmployee)
        {
            return Ok(this.employeeService.AddEmployee(newEmployee));
        }
       
    }
}
