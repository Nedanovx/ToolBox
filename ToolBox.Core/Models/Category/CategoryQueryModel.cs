namespace ToolBox.Core.Models.Category
{
    public class CategoryQueryModel
    {
        public string CategoryName { get; set; } = string.Empty;

        public ICollection<SubCategoryQueryModel> SubCategories { get; set; } = new HashSet<SubCategoryQueryModel>();
    }
}
