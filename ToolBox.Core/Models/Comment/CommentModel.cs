using System.ComponentModel.DataAnnotations;
using static ToolBox.Infrastructure.Constants.ValidationConstants;
using static ToolBox.Core.Constants.Constants;

namespace ToolBox.Core.Models.Comment
{
    public class CommentModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(MaxCommentLength, MinimumLength = MinCommentLength,
            ErrorMessage = CommentLengthErrorMessage)]
        public string ProductComment { get; set; } = string.Empty;

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}
