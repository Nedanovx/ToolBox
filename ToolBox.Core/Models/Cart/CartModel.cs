using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Core.Models.Cart
{
    public class CartModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;

        public ICollection<CartItemsModel> CartItems { get; set; } = new HashSet<CartItemsModel>();
    }
}
