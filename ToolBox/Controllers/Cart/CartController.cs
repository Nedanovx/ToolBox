using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToolBox.Controllers.Base;
using ToolBox.Core.Contracts;

using ToolBox.Infrastructure.Models;

namespace ToolBox.Controllers.Cart
{
    public class CartController : BaseController
    {
        private readonly ICartService cartService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProductService productService;
        public CartController(ICartService cartService, UserManager<ApplicationUser> userManager,
             IProductService productService)
        {
            this.cartService = cartService;
            this.userManager = userManager;
            this.productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity, decimal price, decimal weight)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }
            var product = await productService.GetProductByIdAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            await cartService.AddProductToCartAsync(user.Id, productId, quantity, price, weight);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> AddToCartFromDetails(int productId, int quantity, decimal price, decimal weight)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }
            var product = await productService.GetProductByIdAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            await cartService.AddProductToCartAsync(user.Id, productId, quantity, price, weight);

            return RedirectToAction("Details", "Details", new { sku = product.SKU });
        }
        [HttpGet]
        public async Task<IActionResult> GetCartCount()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }
            var cartCount = await cartService.GetCartCountAsync(user.Id);

            return Json(new { count = cartCount });
        }

        [HttpGet]
        public async Task<IActionResult> ViewAll()
        {
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return BadRequest();
            }

            var model = await cartService.GetAllProductAsync(user.Id);
            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int productId, int quantity)
        {
            if (quantity < 1)
            {
                return BadRequest();
            }
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return Unauthorized();
            }

            await cartService.UpdateCartItemQuantityAsync(user.Id, productId, quantity);
            return RedirectToAction("ViewAll", "Cart");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveItem(int productId)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            await cartService.RemoveCartItemAsync(user.Id, productId);
            return RedirectToAction("ViewAll", "Cart");
        }
    }
}
