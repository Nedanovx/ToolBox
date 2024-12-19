using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ToolBox.Infrastructure.Constants.ValidationConstants;

namespace ToolBox.Infrastructure.Models
{
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxCategoryNameLength)]
        [Comment("Category name")]
        public string CategoryName { get; set; } = string.Empty;

        public ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}
