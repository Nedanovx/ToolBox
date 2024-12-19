using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static ToolBox.Infrastructure.Constants.ValidationConstants;

namespace ToolBox.Infrastructure.Models
{
    public class SubCategory
    {
        [Key]
        [Comment("SubCategory identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxSubCategoryNameLength)]
        [Comment("SubCategory name")]
        public string SubCategoryName { get; set; } = string.Empty;

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public ICollection<ProductSubCategory> ProductSubCategories { get; set; } = new HashSet<ProductSubCategory>();
    }
}
