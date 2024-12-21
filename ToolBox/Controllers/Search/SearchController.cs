using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToolBox.Controllers.Base;
using ToolBox.Core.Contracts;

namespace ToolBox.Controllers.Search
{
    public class SearchController : BaseController
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Search(string text)
        {
            var result = await searchService.SearchProduct(text);
            return View(result);
        }
    }
}
