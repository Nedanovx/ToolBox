using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Core.Models.Cart
{
    public class CartItemsModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Weight { get; set; }
        [Required]
        public decimal Total => Price * Quantity;
        [Required]
        public decimal TotalWeidht => Weight * Quantity;
    }
}
