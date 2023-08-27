namespace oldCapitalWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static oldCapitalWeb.Data.DataConstants.MessageConstatns;

    public class Message
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        [Phone]
        [MaxLength(PhoneMaxLength)]
        public string? Phone { get; set; }

        [MaxLength(SubjectMaxLength)]
        public string? Subject { get; set; }

        [MaxLength(TextMaxLEngth)]
        public string? Text { get; set; }

    }
}
