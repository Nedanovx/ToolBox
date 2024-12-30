using ToolBox.Core.Models.Cart;
namespace ToolBox.Core.Contracts
{
    public interface ICartService
    {
        Task AddProductToCartAsync(string userId, int productId, int quantity, decimal price, decimal weight);
        Task<int> GetCartCountAsync(string userId);
        Task<CartQueryModel> GetAllProductAsync(string userId);

        Task UpdateCartItemQuantityAsync(string userId, int productId, int quantity);
        Task RemoveCartItemAsync(string userId, int productId);
        Task CreateCartAsync(string userId);
    }
}
