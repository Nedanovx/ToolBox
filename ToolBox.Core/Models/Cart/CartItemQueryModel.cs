using ToolBox.Core.Models.Product;

namespace ToolBox.Core.Models.Cart
{
    public class CartItemQueryModel
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal Total { get; set; }
        public decimal TotalWeight { get; set; }

        public ProductQueryModel Product { get; set; } = null!;
    }
}
