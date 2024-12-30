using Microsoft.EntityFrameworkCore;
using ToolBox.Core.Contracts;
using ToolBox.Core.Models.Product;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Core.Services
{
    public class SearchService : ISearchService
    {
        private readonly IRepository repository;

        public SearchService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IEnumerable<ProductQueryModel>> SearchProduct(string text)
        {
            return await repository.AllAsync<Product>()
                .Where(p => p.IsVisible == true)
                .Where(p => p.ProductName.Contains(text) ||
                        p.SKU.Contains(text) ||
                        p.ProductDescription.Contains(text))
            .Select(p => new ProductQueryModel
            {
                Id = p.Id,
                ProductName = p.ProductName,
                SKU = p.SKU,
                ProductPrice = p.ProductPrice,
                ProductDescription = p.ProductDescription,
                IsPromo = p.IsPromo,
                IsInStock = p.IsInStock,
                ImageBase64 = p.Image != null
                    ? Convert.ToBase64String(p.Image)
                    : string.Empty,
                Quantity = p.Quantity,
                Weight = p.Weight,
                PromoPrice = p.PromoPrice,
                Size = p.Size,  
                Characteristic = p.Characteristic,
            })
            .ToListAsync();
        }
    }
}
