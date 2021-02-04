using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAPI.Dtos;
using EmployeeAPI.Models;
using EmployeeAPI.Services;
using EmployeeAPI.Utils.DataValidation;
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

        public async Task<IActionResult> Get()
        {
            return Ok(await this.employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            //@Todo validate the employee exists.
            ServiceResponse<GetEmployeeDto> response = await this.employeeService.GetEmployeeById(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeDto newEmployee)
        {
            
                return Ok(await this.employeeService.AddEmployee(newEmployee));
            
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto newEmployee)
        {
            ServiceResponse<GetEmployeeDto> serviceResponse = await this.employeeService.UpdateEmployee(newEmployee);
            if (serviceResponse.Data == null)
            {
                return NotFound(serviceResponse);
            }
            return Ok(serviceResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponse<List<GetEmployeeDto>> response = await this.employeeService.DeleteEmployee(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("boss/{id}")]
        public async Task<IActionResult> GetByBossId(int id)
        {
            //@Todo validate the author exists.
            ServiceResponse<GetEmployeeDto> response = await this.employeeService.GetEmployeeByBossId(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("count")]
        public async Task<IActionResult> GetEmployeeCount()
        {
            //@Todo validate the author exists.
            ServiceResponse<int> response = await this.employeeService.GetEmployeeCount();
            if (response.Data == 0)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("/Employee/SearchByEmployeeName/{name}")]
        public async Task<IActionResult> SearchEmployeeByName(string name)
        {
            ServiceResponse<List<GetEmployeeDto>> response = await this.employeeService.SearchEmployeeByName(name);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
