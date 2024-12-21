using ToolBox.Core.Contracts;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;
using ToolBox.Core.Models.Comment;
using ToolBox.Core.Models.Details;
using Microsoft.EntityFrameworkCore;

namespace ToolBox.Core.Services
{
    public class DetailService : IDetailService
    {
        private readonly IRepository repository;

        public DetailService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<DetailsQueryModel> DetailsBySKU(string sku)
        {
            return await repository.AllAsync<Product>()
                            .Where(p => p.SKU == sku)
                            .Where(p => p.IsVisible == true)
                            .Select(p => new DetailsQueryModel()
                            {
                                Id = p.Id,
                                ProductName = p.ProductName,
                                ProductDescription = p.ProductDescription,
                                ProductPrice = p.ProductPrice,
                                ImageBase64 = p.Image != null
                            ? Convert.ToBase64String(p.Image)
                            : string.Empty,
                                Quantity = p.Quantity,
                                IsInStock = p.IsInStock,
                                IsPromo = p.IsPromo,
                                PromoPrice = p.PromoPrice,
                                SKU = p.SKU,
                                AllComments = repository.AllAsync<Comment>()
                            .Where(c => c.ProductId == p.Id)
                            .OrderByDescending(c => c.Time)
                            .Select(c => new CommentQueryModel
                            {
                                Id = c.Id,
                                ProductComment = c.ProductComment,
                                DateTime = c.Time,
                                ProductId = c.ProductId,
                                UserId = c.UserId,
                                FirstName = repository.AllAsync<ApplicationUser>()
                                .Where(u => u.Id == c.UserId)
                                .Select(u => u.FirstName)
                                .First(),
                                LastName = repository.AllAsync<ApplicationUser>()
                                .Where(u => u.Id == c.UserId)
                                .Select(u => u.LastName)
                                .First()
                            }).ToList()
                            }).FirstAsync();
        }
    }
}
