namespace ToolBox.Core.Contracts
{
    public interface ICartService
    {
        Task AddProductToCartAsync(string userId, int productId, int quantity, decimal price, decimal weight);
        Task<int> GetCartCountAsync(string userId);
    }
}
