using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static ToolBox.Infrastructure.Constants.ValidationConstants;

namespace ToolBox.Infrastructure.Models
{
    public class Comment
    {
        [Key]
        [Comment("Comment identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxCommentLength)]
        [Comment("Comment about product")]
        public string ProductComment { get; set; } = string.Empty;

        [Required]
        [Comment("Post's date and time")]
        public DateTime Time { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
