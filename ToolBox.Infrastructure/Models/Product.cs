using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static ToolBox.Infrastructure.Constants.ValidationConstants;

namespace ToolBox.Infrastructure.Models
{
    public class Product
    {
        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxProductNameLength)]
        [Comment("Product name")]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxSKULength)]
        [Comment("Product's number")]
        public string SKU { get; set; } = string.Empty;

        [Comment("Product description")]
        [StringLength(MaxDescriptionLength)]
        public string? ProductDescription { get; set; }

        [Comment("Product size")]
        public string? Size { get; set; }

        [Required]
        [Comment("Product image")]
        public byte[]? Image { get; set; } 

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("Product price")]
        public decimal ProductPrice { get; set; }

        [Required]
        [Comment("Product quantity")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("Product weight")]
        public decimal Weight { get; set; }

        [Required]
        [Comment("Product is visible to the user")]
        public bool IsVisible { get; set; } = true;

        [Required]
        [Comment("Is product exist")]
        public bool IsInStock { get; set; } = true;

        [Required]
        [Comment("Is product has promo price")]
        public bool IsPromo { get; set; } = false;

        [Column(TypeName = "decimal(18,2)")]
        [Comment("Promo price")]
        public decimal PromoPrice { get; set; }

        public ICollection<ProductSubCategory> ProductSubCategories { get; set; } = new HashSet<ProductSubCategory>();

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

    }
}
