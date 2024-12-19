using ToolBox.Core.Models.Product;
namespace ToolBox.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductQueryModel>> AllProductAsync();
    }
}
