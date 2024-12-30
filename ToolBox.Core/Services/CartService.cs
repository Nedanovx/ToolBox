using Microsoft.EntityFrameworkCore;
using ToolBox.Core.Contracts;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;
using ToolBox.Core.Models.Cart;
using ToolBox.Core.Models.Product;

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
                throw new InvalidOperationException();
            }
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            var product = await productService.GetProductByIdAsync(productId);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
                cartItem.Weight = weight;
                cartItem.TotalWeight += cartItem.Weight;
                cartItem.Total += price;
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
                    Total = price * quantity,
                    TotalWeight = weight * quantity,
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
        public async Task<CartQueryModel> GetAllProductAsync(string userId)
        {
            return await repository.AllAsync<Cart>()
        .Where(c => c.UserId == userId)
        .Include(c => c.CartItems)
        .ThenInclude(ci => ci.Product) 
        .Select(c => new CartQueryModel()
        {
            UserId = userId,
            CartItems = c.CartItems.Select(ci => new CartItemQueryModel()
            {
                ProductId = ci.ProductId,
                Quantity = ci.Quantity,
                CartId = ci.CartId,
                Price = ci.Price,
                Weight = ci.Weight,
                Total = ci.Total,
                TotalWeight = ci.TotalWeight,
                Product = new ProductQueryModel
                {
                    Id = ci.Product.Id,
                    SKU = ci.Product.SKU,
                    ProductName = ci.Product.ProductName,
                    ProductPrice = ci.Product.ProductPrice,
                    PromoPrice = ci.Product.ProductPrice,
                    Quantity = ci.Product.Quantity
                }
            }).ToList()
        }).FirstAsync();
        }

        public async Task UpdateCartItemQuantityAsync(string userId, int productId, int quantity)
        {
            var cartItem = await repository.AllAsync<CartItem>()
        .Include(ci => ci.Cart) 
        .Where(ci => ci.Cart.UserId == userId && ci.ProductId == productId)
        .FirstOrDefaultAsync();


            if (cartItem == null)
            {
                throw new InvalidOperationException();
            }

            cartItem.Quantity = quantity;
            cartItem.Total = quantity * cartItem.Price;
            cartItem.TotalWeight = quantity * cartItem.Weight;

            await repository.SaveChangesAsync();
        }

        public async Task RemoveCartItemAsync(string userId, int productId)
        {
            var cartItem = await repository.AllAsync<CartItem>()
         .Include(ci => ci.Cart)
         .Where(ci => ci.Cart.UserId == userId && ci.ProductId == productId)
        .FirstOrDefaultAsync();

            if (cartItem == null)
            {
                throw new InvalidOperationException();
            }

            await repository.RemoveAsync(cartItem);
            await repository.SaveChangesAsync();
        }

        public async Task CreateCartAsync(string userId)
        {
            var cart = new Cart { UserId = userId };
            await repository.AddAsync(cart);
            await repository.SaveChangesAsync();
        }
    }
}
