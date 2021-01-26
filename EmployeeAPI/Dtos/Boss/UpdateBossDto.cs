using System;
namespace EmployeeAPI.Dtos.Boss
{
    public class UpdateBossDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "Kristina";
        public string LastName { get; set; } = "Cer";
    }
}
