using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToolBox.Core.Contracts;

namespace ToolBox.Areas.Admin.Controllers
{
    public class AdminController : AdminBaseController
    {
        private readonly IProductService productService;

        public AdminController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allProduct = await productService.AllProductAsync();

            return View(allProduct);
        }
    }
}
