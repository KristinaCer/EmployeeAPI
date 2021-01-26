using System;
namespace EmployeeAPI.Dtos.Boss
{
    public class GetBossDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "Kristina";
        public string LastName { get; set; } = "Cer";
    }
}
