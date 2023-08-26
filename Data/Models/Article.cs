using System.ComponentModel.DataAnnotations;

using static oldCapitalWeb.Data.DataConstants.ArticleConstatns;

namespace oldCapitalWeb.Data.Models
{
    public class Article
    {
        public Guid Id { get; init; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(TextMaxLength)]
        public string Text { get; set; } = null!;
    }
}
