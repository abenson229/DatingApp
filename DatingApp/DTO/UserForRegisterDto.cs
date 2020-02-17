using System.ComponentModel.DataAnnotations;

namespace DatingApp.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be 4 - 8 chars inclusive")]
        public string Password { get; set; }
    }
}