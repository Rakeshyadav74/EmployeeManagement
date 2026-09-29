using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DTOs
{
    public class UpdateEmployeeDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Department { get; set; } = string.Empty;

        [Range(0, 10000000)]
        public decimal Salary { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;
    }
}
