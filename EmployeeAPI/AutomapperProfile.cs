using System;
using AutoMapper;
using EmployeeAPI.Dtos;
using EmployeeAPI.Models;

namespace EmployeeAPI
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, GetEmployeeDto>();
        }
    }
}
