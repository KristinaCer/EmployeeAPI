using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAPI.Models
{
    public class Role
    {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int Id { get; set; }
     [Required]
     [MaxLength(100, ErrorMessage = "Role name cannot be longer than 100 characters.")]
     public string Description { get; set; }
     public Employee Employee { get; set; }
    } 
}
