using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToolBox.Controllers.Base;
using ToolBox.Models;
using ToolBox.Core.Contracts;

namespace ToolBox.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allProduct = await productService.AllProductAsync();

            return View(allProduct);
        }


        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("StatusCodeError/{statusCode}")]
        public IActionResult Error(int statusCode)
        {

            if (statusCode == 400)
            {
                return View("Error400");
            }
            else if (statusCode == 401)
            {
                return View("Error401");
            }


            return View("Error");
        }
    }
}
