using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToolBox.Controllers.Base;
using ToolBox.Core.Contracts;
using ToolBox.Core.Services;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Controllers.Category
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Category(string category)
        {
            ViewData["Title"] = category;

            var model = await categoryService.GetAllProductByCategory(category);
            if (model == null)
            {
                return BadRequest();
            }
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> SubCategory(string subCategory)
        {
            ViewData["Title"] = subCategory;

            var model = await categoryService.GetAllProductBySubCategory(subCategory);
            if (model == null)
            {
                return BadRequest();
            }
            return View(model);
        }
    }
}
