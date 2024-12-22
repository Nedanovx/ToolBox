using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;
using ToolBox.Core.Models.Product;
using ToolBox.Core.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ToolBox.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ProductQueryModel>> AllProductAsync()
        {
            return await repository.AllAsync<Product>()
                .Where(p => p.IsVisible == true)
                .Select(p => new ProductQueryModel()
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    SKU = p.SKU,
                    ProductDescription = p.ProductDescription,
                    Size = p.Size,
                    Characteristic = p.Characteristic,
                    ImageBase64 = p.Image != null
                    ? Convert.ToBase64String(p.Image)
                    : string.Empty,
                    ProductPrice = p.ProductPrice,
                    Quantity = p.Quantity,
                    Weight = p.Weight,
                    IsInStock = p.IsInStock,
                    IsPromo = p.IsPromo,
                    PromoPrice = p.PromoPrice,
                })
                .OrderByDescending(p => p.Id)
                .ToListAsync();
        }

        public async Task<bool> ProductExistBySKUAsync(string sku)
        {
            return await repository.AllAsync<Product>()
                .AnyAsync(p => p.SKU == sku);
        }

        public async Task<ProductQueryModel> GetProductByIdAsync(int id)
        {
            return await repository.AllAsync<Product>()
                .Where(p => p.Id == id)
                .Select(p => new ProductQueryModel()
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    SKU = p.SKU,
                    ProductDescription = p.ProductDescription,
                    Size = p.Size,
                    Characteristic = p.Characteristic,
                    ImageBase64 = p.Image != null
                    ? Convert.ToBase64String(p.Image)
                    : string.Empty,
                    ProductPrice = p.ProductPrice,
                    Quantity = p.Quantity,
                    Weight = p.Weight,
                    IsInStock = p.IsInStock,
                    IsPromo = p.IsPromo,
                    PromoPrice = p.PromoPrice,
                }).FirstAsync();
        }

    }
}
