using System.ComponentModel.DataAnnotations;
using E_Commerce_Playground.Data.Enums;

namespace E_Commerce_Playground.Models
{
    public class User
    {
        [Key]

        public int UserId { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password!", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please provide email address!", AllowEmptyStrings = false)]

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string ProfilePictureURL { get; set; }
        public AccountType AccountLevel { get; set; }



        



    }
}
