using System.ComponentModel.DataAnnotations;

namespace oldCapitalWeb.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 5)]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, MinimumLength = 8)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 5)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}
