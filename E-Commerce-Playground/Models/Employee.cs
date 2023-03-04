using E_Commerce_Playground.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Playground.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string EmploymentAddress { get; set; }
        [Required]
        public EmploymentLevel EmploymentLevel { get; set; }
        [Required]
        public decimal Salary { get; set; }

     
    }
}
