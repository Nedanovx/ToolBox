using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToolBox.Controllers.Base;
using ToolBox.Core.Contracts;

namespace ToolBox.Controllers.Details
{
    public class DetailsController : BaseController
    {
        private readonly IDetailService detailService;
        private readonly IProductService productService;
        public DetailsController(IDetailService detailService, IProductService productService)
        {
            this.detailService = detailService;
            this.productService = productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string sku)
        {
            if (!await productService.ProductExistBySKUAsync(sku))
            {
                return BadRequest();
            }

            var model = await detailService.DetailsBySKUAsync(sku);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> RedirectToSku(int id)
        {
            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return RedirectToAction("Details", new { sku = product.SKU });
        }
    }
}
