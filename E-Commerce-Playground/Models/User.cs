using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Playground.Models
{
    public class User
    {
        [Key]

        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string ProfilePictureURL { get; set; }



    }
}
