using ToolBox.Core.Models.Category;
using ToolBox.Core.Models.Product;
namespace ToolBox.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryQueryModel>> AllCategoryAsync();
        Task<IEnumerable<ProductQueryModel>> GetAllProductByCategoryAsync(string category);
        Task<IEnumerable<ProductQueryModel>> GetAllProductBySubCategoryAsync(string subCategory);
    }
}
