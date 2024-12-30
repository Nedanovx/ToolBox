using ToolBox.Infrastructure.Models;

namespace ToolBox.Core.Models.Category
{
    public class SubCategoryQueryModel
    {
        public string SubCategoryName { get; set; } = string.Empty;
        public ICollection<ProductSubCategory> ProductSubCategories { get; set; } = new HashSet<ProductSubCategory>();
    }
}
