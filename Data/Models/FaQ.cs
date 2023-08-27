namespace oldCapitalWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static oldCapitalWeb.Data.DataConstants.FaQConstatns;

    public class FaQ
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(QuestionMaxLength)]
        public string Question { get; set; } = null!;

        [Required]
        [MaxLength(AnswerMaxLength)]
        public string Answer { get; set; } = null!;
    }
}
