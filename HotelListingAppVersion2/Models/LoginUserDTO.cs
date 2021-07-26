using System.ComponentModel.DataAnnotations;

namespace HotelListingAppVersion2.Models
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} charactes", MinimumLength = 6)]
        public string password { get; set; }
    }
}
