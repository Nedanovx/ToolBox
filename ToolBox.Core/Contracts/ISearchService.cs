using ToolBox.Core.Models.Product;

namespace ToolBox.Core.Contracts
{
    public interface ISearchService
    {
        Task<IEnumerable<ProductQueryModel>> SearchProduct(string text);
    }
}
