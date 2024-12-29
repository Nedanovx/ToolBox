using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Core.Models.Cart
{
    public class CartQueryModel
    {
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        public ICollection<CartItemsQueryModel> CartItems { get; set; } = new HashSet<CartItemsQueryModel>();
    }
}
