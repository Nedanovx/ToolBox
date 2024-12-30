using ToolBox.Core.Contracts;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;
using ToolBox.Core.Models.Category;
using Microsoft.EntityFrameworkCore;
using ToolBox.Core.Models.Product;

namespace ToolBox.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<CategoryQueryModel>> AllCategoryAsync()
        {
            return await repository.AllAsync<Category>()
                .Include(sc => sc.SubCategories)
                .Select(c => new CategoryQueryModel
                {
                    CategoryName = c.CategoryName,
                    SubCategories = c.SubCategories.Select(sc => new SubCategoryQueryModel 
                    { 
                        SubCategoryName = sc.SubCategoryName 
                    }).ToList(),
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductQueryModel>> GetAllProductByCategoryAsync(string category)
        {
            return await repository.AllAsync<Product>()
                .Where(p => p.IsVisible == true)
                .Include(p => p.ProductSubCategories)
                .ThenInclude(psc => psc.SubCategory)
                .Where(p => p.ProductSubCategories.Any(psc =>

                psc.SubCategory.Category.CategoryName == category))
                .Select(p => new ProductQueryModel
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
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductQueryModel>> GetAllProductBySubCategoryAsync(string subCategory)
        {
            return await repository.AllAsync<Product>()
                .Where(p => p.IsVisible == true)
                .Include(p => p.ProductSubCategories)
                .ThenInclude(psc => psc.SubCategory)
                .Where(p => p.ProductSubCategories.Any(psc => psc.SubCategory.SubCategoryName == subCategory))
                .Select(p => new ProductQueryModel
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
                .ToListAsync();
        }
    }
}
