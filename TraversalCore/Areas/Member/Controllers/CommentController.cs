using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [Area("Member")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
