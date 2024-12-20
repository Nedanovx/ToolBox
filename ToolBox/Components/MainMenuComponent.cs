using Microsoft.AspNetCore.Mvc;
using ToolBox.Core.Contracts;

namespace ToolBox.Components
{
    public class MainMenuComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public MainMenuComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.AllCategoryAsync();

            return await Task.FromResult(View(categories));
        }
    }
}
