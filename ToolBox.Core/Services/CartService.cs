using Microsoft.EntityFrameworkCore;
using ToolBox.Core.Contracts;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Core.Services
{
    public class CartService : ICartService
    {
        private readonly IRepository repository;
        private readonly IProductService productService;

        public CartService(IRepository repository, IProductService productService)
        {
            this.repository = repository;
            this.productService = productService;
        }


        public async Task AddProductToCartAsync(string userId, int productId, int quantity, decimal price, decimal weight)
        {
            var cart = await repository.AllAsync<Cart>()
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await repository.AddAsync(cart);
                await repository.SaveChangesAsync();
            }
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            var product = await productService.GetProductByIdAsync(productId);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
                cartItem.Weight = weight;
            }
            else
            {
                cart.CartItems.Add(new CartItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    CartId = cart.Id,
                    Price = price,
                    Weight = weight,       
                    
                });
            }

            await repository.SaveChangesAsync();
        }

        public async Task<int> GetCartCountAsync(string userId)
        {
            var cart = await repository.AllAsync<Cart>()
        .Where(c => c.UserId == userId)
        .Include(c => c.CartItems)
        .FirstOrDefaultAsync();

            if (cart == null)
            {
                return 0;
            }
            return cart.CartItems.Sum(ci => ci.Quantity);
        }
            
    }
}
