namespace oldCapitalWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static oldCapitalWeb.Data.DataConstants.ArtistConstatns;

    public class Artist
    {
        public Guid Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public ICollection<string> MediaLinks { get; set; } = new List<string>();

    }
}
