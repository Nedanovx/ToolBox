using ToolBox.Core.Models.Category;
namespace ToolBox.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryQueryModel>> AllCategoryAsync();
    }
}
