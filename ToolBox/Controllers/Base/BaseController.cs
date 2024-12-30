using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToolBox.Controllers.Base
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
