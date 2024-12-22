using ToolBox.Core.Models.Category;
using ToolBox.Core.Models.Product;
namespace ToolBox.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryQueryModel>> AllCategoryAsync();
        Task<IEnumerable<ProductQueryModel>> GetAllProductByCategory(string category);
        Task<IEnumerable<ProductQueryModel>> GetAllProductBySubCategory(string subCategory);
    }
}
