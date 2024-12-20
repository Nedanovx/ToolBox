using ToolBox.Core.Contracts;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;
using ToolBox.Core.Models.Category;
using Microsoft.EntityFrameworkCore;

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
    }
}
