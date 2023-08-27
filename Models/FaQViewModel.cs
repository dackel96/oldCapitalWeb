namespace oldCapitalWeb.Models
{
    using System.ComponentModel.DataAnnotations;

    using static ClientDataConstants.FaQConstatns;

    public class FaQViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(QuestionMaxLength, MinimumLength = QuestionMinLength)]
        public string Question { get; set; } = null!;

        [Required]
        [StringLength(AnswerMaxLength, MinimumLength = AnswerMinLength)]
        public string Answer { get; set; } = null!;
    }
}
