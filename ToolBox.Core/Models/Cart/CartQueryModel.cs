namespace ToolBox.Core.Models.Cart
{
    public class CartQueryModel
    {
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        public ICollection<CartItemQueryModel> CartItems { get; set; } = new HashSet<CartItemQueryModel>();
    }
}
