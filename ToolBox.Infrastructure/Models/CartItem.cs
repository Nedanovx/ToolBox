using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;


namespace ToolBox.Infrastructure.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Weight { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total => Price * Quantity;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalWeidht => Weight * Quantity;
    }
}
