using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToolBox.Controllers.Base;
using ToolBox.Infrastructure.Models;
using ToolBox.Core.Contracts;
using ToolBox.Core.Models.Comment;
using Microsoft.IdentityModel.Tokens;

namespace ToolBox.Controllers.Comment
{
    public class CommentController : BaseController
    {
        private readonly ICommentService commentService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProductService productService;
        private readonly IDetailService detailService;
        public CommentController(ICommentService commentService, UserManager<ApplicationUser> userManager,
            IProductService productService, IDetailService detailService)
        {
            this.commentService = commentService;
            this.userManager = userManager;
            this.productService = productService;
            this.detailService = detailService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(string sku)
        {
            var currentUser = await userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return Unauthorized();
            }
            var product = await detailService.DetailsBySKU(sku);
            if (product == null)
            {
                return NotFound();
            }

            var model = new AddCommentModel();
            model.UserId = currentUser.Id;
            model.DateTime = DateTime.Now;
            model.ProductId = product.Id;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCommentModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var product = await productService.GetProductById(model.ProductId);
            if (product == null)
            {
                return NotFound();
            }
            await commentService.AddCommentAsync(model);
      
            return RedirectToAction("Details", "Details", new { sku = product.SKU });
        }
    }
}
