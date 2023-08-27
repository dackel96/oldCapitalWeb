namespace oldCapitalWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static oldCapitalWeb.Data.DataConstants.ContactUsConstatns;

    public class ContactUs
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [Phone]
        [MaxLength(PhoneMaxLength)]
        public string Phone { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(MapLinkMaxLength)]
        public string MapLink { get; set; } = null!;
    }
}
